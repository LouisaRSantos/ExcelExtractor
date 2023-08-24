using System;
using OfficeOpenXml;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Data;
using System.Diagnostics;

namespace EE__Excel_Extractor_
{
    public partial class Form1 : Form
    {
        private string inputFilePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                openFileDialog.Title = "Select Excel File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputFilePath = openFileDialog.FileName;
                    textBox_fileName.Text = openFileDialog.FileName;
                    lbl_filename.Visible = true;
                    lbl_filename.Text = "Uploaded. Ready to extract."; // Display the selected file path in a TextBox or Label

                    
                }

                LoadExcelData(inputFilePath);
            }
        }

        private void LoadExcelData(string filePath)
        {
            try
            {
                using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Assuming you're working with the first sheet

                    DataTable dataTable = new DataTable();

                    // Populate column headers from Excel
                    foreach (var headerCell in worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
                    {
                        dataTable.Columns.Add(headerCell.Text);
                    }

                    // Populate data rows from Excel
                    for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                    {
                        DataRow dataRow = dataTable.NewRow();
                        for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                        {
                            dataRow[col - 1] = worksheet.Cells[row, col].Text;
                        }
                        dataTable.Rows.Add(dataRow);
                    }

                    // Bind DataTable to DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a file.");
                return;
            }
        }

        private void btn_extract_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputFilePath))
            {
                MessageBox.Show("Please select an Excel file first.");
                return;
            }

            string selectedColumn = cbox_Region.SelectedItem?.ToString(); // Get the selected column header from ComboBox
            if (string.IsNullOrEmpty(selectedColumn))
            {
                MessageBox.Show("Please select a column from the ComboBox.");
                return;
            }

            string searchText = txtRegion.Text.Trim().ToUpper(); // Get the value to search from the TextBox
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a value to search.");
                return;
            }

            using (ExcelPackage package = new ExcelPackage(new FileInfo(inputFilePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Assuming you're working with the first sheet

                int lastRow = worksheet.Dimension.End.Row;
                int lastCol = worksheet.Dimension.End.Column;

                int selectedColumnIndex = -1; // Initialize the selected column index

                // Find the index of the selected column
                for (int col = 1; col <= lastCol; col++)
                {
                    string columnName = worksheet.Cells[1, col]?.Text;

                    if (columnName == selectedColumn)
                    {
                        selectedColumnIndex = col;
                        break; // Exit the loop once the column is found
                    }
                }

                if (selectedColumnIndex == -1)
                {
                    MessageBox.Show("Selected column not found.");
                    return;
                }

                // Check if searchText exists in the selected column
                bool searchTextFound = false;

                for (int row = 2; row <= lastRow; row++) // Start from row 2 to skip the header
                {
                    string cellValue = worksheet.Cells[row, selectedColumnIndex]?.Text; // Get cell value of selected column

                    if (!string.IsNullOrEmpty(cellValue) && cellValue.Trim().ToUpper() == searchText)
                    {
                        searchTextFound = true;
                        break; // Exit the loop if searchText is found
                    }
                }

                if (!searchTextFound)
                {
                    MessageBox.Show("Search text not found in the selected column.");
                    return; // Exit if searchText is not found
                }

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    saveFileDialog.Title = "Save Extracted Data As";
                    saveFileDialog.FileName = "extracted.xlsx"; // Default file name

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string outputFilePath = saveFileDialog.FileName;

                        using (ExcelPackage outputPackage = new ExcelPackage())
                        {
                            ExcelWorksheet outputWorksheet = outputPackage.Workbook.Worksheets.Add("Extracted Data");

                            int newRow = 1; // Start from row 1 for extracted data

                            // Copy header row from source worksheet to the output worksheet
                            for (int col = 1; col <= lastCol; col++)
                            {
                                outputWorksheet.Cells[newRow, col].Value = worksheet.Cells[1, col].Value;
                            }

                            newRow++;

                            for (int row = 2; row <= lastRow; row++) // Start from row 2 to skip the header
                            {
                                string cellValue = worksheet.Cells[row, selectedColumnIndex]?.Text; // Get cell value of selected column

                                if (!string.IsNullOrEmpty(cellValue) && cellValue.Trim().ToUpper() == searchText)
                                {

                                    // Extract the entire row
                                    for (int col = 1; col <= lastCol; col++)
                                    {
                                        outputWorksheet.Cells[newRow, col].Value = worksheet.Cells[row, col].Text;
                                    }

                                    newRow++;
                                }
                            }

                            if ((newRow > 1))
                            {
                                // Save the output Excel file if data was extracted
                                FileInfo outputFile = new FileInfo(outputFilePath);
                                outputPackage.SaveAs(outputFile);

                                MessageBox.Show("Extraction complete. Extracted data saved to output file.");

                                string fileDirectory = Path.GetDirectoryName(outputFilePath);

                                // Check if the directory exists and then open it in the file explorer
                                if (Directory.Exists(fileDirectory))
                                {
                                    Process.Start("explorer.exe", $"/select,\"{outputFilePath}\"");
                                }
                            }
                            else
                            {
                                MessageBox.Show("No matching data found for the selected column and value.");
                            }
                        }
                    }
                }
            }
        }

        private void labelEnter_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtbox_index.Text, out int rowIndex))
            {
                using (var package = new ExcelPackage(new FileInfo(inputFilePath)))
                {
                    var worksheet = package.Workbook.Worksheets[0]; // Assuming the data is on the first sheet

                    // Check if the index is valid (between 1 and the number of rows)
                    if (rowIndex >= 1 && rowIndex <= worksheet.Dimension.End.Row)
                    {
                        // Fetch the entire row for the specified index
                        var headerRow = worksheet.Cells[rowIndex, 1, rowIndex, worksheet.Dimension.Columns];

                        // Initialize cbox_Region with the fetched headers
                        cbox_Region.Items.Clear();
                        foreach (var headerCell in headerRow)
                        {
                            string columnName = headerCell.Text;
                            cbox_Region.Items.Add(columnName);
                        }

                        cbox_Region.SelectedIndex = 0; // Select the first header

                        labelColumn.Visible = true;
                        cbox_Region.Visible = true;
                        labelFilter.Visible = true;
                        txtRegion.Visible = true;
                        btn_extract.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid row index.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer index.");
            }
        }
    }
}
