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
        private string selectedProvince;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_extract_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputFilePath))
            {
                MessageBox.Show("Please select an Excel file first.");
                return;
            }

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            selectedProvince = txtInput.Text.Trim().ToUpper();

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

                            // Copy header row from source worksheet to the output worksheet
                            for (int col = 1; col <= lastCol; col++)
                            {
                                outputWorksheet.Cells[1, col].Value = worksheet.Cells[1, col].Value;
                            }

                            int newRow = 2; // Start from row 2 for extracted data

                            for (int row = 2; row <= lastRow; row++) // Start from row 2 to skip the header
                            {
                                for (int col = 1; col <= lastCol; col++)
                                {
                                    string cellValue = worksheet.Cells[row, col]?.Text;

                                    if (!string.IsNullOrEmpty(cellValue) && cellValue.Contains(selectedProvince))
                                    {
                                        // Extract the entire row
                                        for (int copyCol = 1; copyCol <= lastCol; copyCol++)
                                        {
                                            outputWorksheet.Cells[newRow, copyCol].Value = worksheet.Cells[row, copyCol].Text;
                                        }

                                        newRow++;
                                        break; // Break the column loop since we found the keyword in this row
                                    }
                                }
                            }

                            // Save the output Excel file
                            FileInfo outputFile = new FileInfo(outputFilePath);
                            outputPackage.SaveAs(outputFile);

                            MessageBox.Show("Extraction complete. Extracted data saved to output file.");
                        }
                    }
                }
            }
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
                    lbl_filename.Text = "Uploaded. Ready to extract."; // Display the selected file path in a TextBox or Label
                }
            }
        }
    }
}
