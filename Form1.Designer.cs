
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
            this.SuspendLayout();
            // 
            // btn_extract
            // 
            this.btn_extract.Location = new System.Drawing.Point(462, 280);
            this.btn_extract.Name = "btn_extract";
            this.btn_extract.Size = new System.Drawing.Size(75, 23);
            this.btn_extract.TabIndex = 0;
            this.btn_extract.Text = "Extract";
            this.btn_extract.UseVisualStyleBackColor = true;
            this.btn_extract.Click += new System.EventHandler(this.btn_extract_Click);
            // 
            // cbox_Region
            // 
            this.cbox_Region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_Region.FormattingEnabled = true;
            this.cbox_Region.Location = new System.Drawing.Point(34, 100);
            this.cbox_Region.Name = "cbox_Region";
            this.cbox_Region.Size = new System.Drawing.Size(136, 21);
            this.cbox_Region.TabIndex = 1;
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(437, 32);
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
            this.txtRegion.Location = new System.Drawing.Point(34, 127);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(136, 20);
            this.txtRegion.TabIndex = 4;
            // 
            // textBox_fileName
            // 
            this.textBox_fileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_fileName.Enabled = false;
            this.textBox_fileName.Location = new System.Drawing.Point(33, 34);
            this.textBox_fileName.Name = "textBox_fileName";
            this.textBox_fileName.Size = new System.Drawing.Size(398, 20);
            this.textBox_fileName.TabIndex = 5;
            this.textBox_fileName.Text = "Choose file:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 331);
            this.Controls.Add(this.textBox_fileName);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.lbl_filename);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.cbox_Region);
            this.Controls.Add(this.btn_extract);
            this.Name = "Form1";
            this.Text = "REGION";
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
    }
}

