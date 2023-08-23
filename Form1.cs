using System;
using OfficeOpenXml;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace EE__Excel_Extractor_
{
    public partial class Form1 : Form
    {
        private string selectedBarangay;
        private string inputFilePath;
        private string selectedRegion;
        private string selectedColumn;
        private byte[] excelFileData;

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

                    using (var package = new ExcelPackage(new FileInfo(inputFilePath)))
                    {
                        var worksheet = package.Workbook.Worksheets[0]; // Assuming the data is on the first sheet
                        var headerRow = worksheet.Cells[1, 1, 1, worksheet.Dimension.Columns];

                        foreach (var cell in headerRow)
                        {
                            string columnName = cell.Text;
                            cbox_Region.Items.Add(columnName);
                        }
                    }
                }
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

                            if (newRow > 1)
                            {
                                // Save the output Excel file if data was extracted
                                FileInfo outputFile = new FileInfo(outputFilePath);
                                outputPackage.SaveAs(outputFile);

                                MessageBox.Show("Extraction complete. Extracted data saved to output file.");
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
    }
}
