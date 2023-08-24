
namespace EE__Excel_Extractor_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_extract = new System.Windows.Forms.Button();
            this.cbox_Region = new System.Windows.Forms.ComboBox();
            this.btn_upload = new System.Windows.Forms.Button();
            this.lbl_filename = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.textBox_fileName = new System.Windows.Forms.TextBox();
            this.labelColumn = new System.Windows.Forms.Label();
            this.labelFilter = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtbox_index = new System.Windows.Forms.TextBox();
            this.labelIndex = new System.Windows.Forms.Label();
            this.labelEnter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_extract
            // 
            this.btn_extract.Location = new System.Drawing.Point(265, 211);
            this.btn_extract.Name = "btn_extract";
            this.btn_extract.Size = new System.Drawing.Size(75, 23);
            this.btn_extract.TabIndex = 0;
            this.btn_extract.Text = "Extract";
            this.btn_extract.UseVisualStyleBackColor = true;
            this.btn_extract.Visible = false;
            this.btn_extract.Click += new System.EventHandler(this.btn_extract_Click);
            // 
            // cbox_Region
            // 
            this.cbox_Region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_Region.FormattingEnabled = true;
            this.cbox_Region.Location = new System.Drawing.Point(33, 155);
            this.cbox_Region.Name = "cbox_Region";
            this.cbox_Region.Size = new System.Drawing.Size(136, 21);
            this.cbox_Region.TabIndex = 1;
            this.cbox_Region.Visible = false;
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(265, 34);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(75, 23);
            this.btn_upload.TabIndex = 2;
            this.btn_upload.Text = "Upload";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // lbl_filename
            // 
            this.lbl_filename.AutoSize = true;
            this.lbl_filename.Enabled = false;
            this.lbl_filename.Location = new System.Drawing.Point(31, 62);
            this.lbl_filename.Name = "lbl_filename";
            this.lbl_filename.Size = new System.Drawing.Size(91, 13);
            this.lbl_filename.TabIndex = 3;
            this.lbl_filename.Text = "File not uploaded.";
            this.lbl_filename.Visible = false;
            // 
            // txtRegion
            // 
            this.txtRegion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegion.Location = new System.Drawing.Point(33, 211);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(136, 20);
            this.txtRegion.TabIndex = 4;
            this.txtRegion.Visible = false;
            // 
            // textBox_fileName
            // 
            this.textBox_fileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_fileName.Enabled = false;
            this.textBox_fileName.Location = new System.Drawing.Point(33, 34);
            this.textBox_fileName.Name = "textBox_fileName";
            this.textBox_fileName.Size = new System.Drawing.Size(214, 20);
            this.textBox_fileName.TabIndex = 5;
            this.textBox_fileName.Text = "Choose file:";
            // 
            // labelColumn
            // 
            this.labelColumn.AutoSize = true;
            this.labelColumn.Location = new System.Drawing.Point(32, 131);
            this.labelColumn.Name = "labelColumn";
            this.labelColumn.Size = new System.Drawing.Size(156, 13);
            this.labelColumn.TabIndex = 6;
            this.labelColumn.Text = "Choose column to filter through:";
            this.labelColumn.Visible = false;
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(31, 193);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(121, 13);
            this.labelFilter.TabIndex = 7;
            this.labelFilter.Text = "Specify value to extract:";
            this.labelFilter.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(447, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(465, 385);
            this.dataGridView1.TabIndex = 8;
            // 
            // txtbox_index
            // 
            this.txtbox_index.Location = new System.Drawing.Point(193, 93);
            this.txtbox_index.Name = "txtbox_index";
            this.txtbox_index.Size = new System.Drawing.Size(42, 20);
            this.txtbox_index.TabIndex = 9;
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Location = new System.Drawing.Point(30, 96);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(157, 13);
            this.labelIndex.TabIndex = 10;
            this.labelIndex.Text = "Specify the index of the header:";
            // 
            // labelEnter
            // 
            this.labelEnter.AutoSize = true;
            this.labelEnter.Location = new System.Drawing.Point(242, 97);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(32, 13);
            this.labelEnter.TabIndex = 11;
            this.labelEnter.Text = "Enter";
            this.labelEnter.Click += new System.EventHandler(this.labelEnter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 437);
            this.Controls.Add(this.labelEnter);
            this.Controls.Add(this.labelIndex);
            this.Controls.Add(this.txtbox_index);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.labelColumn);
            this.Controls.Add(this.textBox_fileName);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.lbl_filename);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.cbox_Region);
            this.Controls.Add(this.btn_extract);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGION";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_extract;
        private System.Windows.Forms.ComboBox cbox_Region;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Label lbl_filename;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox textBox_fileName;
        private System.Windows.Forms.Label labelColumn;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbox_index;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.Label labelEnter;
    }
}

