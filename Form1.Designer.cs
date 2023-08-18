
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
            this.cbox_options = new System.Windows.Forms.ComboBox();
            this.btn_upload = new System.Windows.Forms.Button();
            this.lbl_filename = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_extract
            // 
            this.btn_extract.Location = new System.Drawing.Point(172, 140);
            this.btn_extract.Name = "btn_extract";
            this.btn_extract.Size = new System.Drawing.Size(75, 23);
            this.btn_extract.TabIndex = 0;
            this.btn_extract.Text = "Extract";
            this.btn_extract.UseVisualStyleBackColor = true;
            this.btn_extract.Click += new System.EventHandler(this.btn_extract_Click);
            // 
            // cbox_options
            // 
            this.cbox_options.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_options.FormattingEnabled = true;
            this.cbox_options.Items.AddRange(new object[] {
            "ANGAT",
            "BALAGTAS (BIGAA)",
            "BALIUAG",
            "BOCAUE",
            "BULACAN",
            "BUSTOS",
            "CALUMPIT",
            "CITY OF MALOLOS (Capital)",
            "CITY OF MEYCAUAYAN",
            "CITY OF SAN JOSE DEL MONTE",
            "DOÑA REMEDIOS TRINIDAD",
            "GUIGUINTO",
            "HAGONOY",
            "MARILAO",
            "NORZAGARAY",
            "OBANDO",
            "PANDI",
            "PAOMBONG",
            "PLARIDEL",
            "PULILAN",
            "SAN ILDEFONSO",
            "SAN MIGUEL",
            "SAN RAFAEL",
            "SANTA MARIA"});
            this.cbox_options.Location = new System.Drawing.Point(33, 185);
            this.cbox_options.Name = "cbox_options";
            this.cbox_options.Size = new System.Drawing.Size(214, 21);
            this.cbox_options.TabIndex = 1;
            this.cbox_options.Visible = false;
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(33, 140);
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
            this.lbl_filename.Location = new System.Drawing.Point(30, 62);
            this.lbl_filename.Name = "lbl_filename";
            this.lbl_filename.Size = new System.Drawing.Size(35, 13);
            this.lbl_filename.TabIndex = 3;
            this.lbl_filename.Text = "label1";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(33, 101);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(120, 20);
            this.txtInput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 239);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lbl_filename);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.cbox_options);
            this.Controls.Add(this.btn_extract);
            this.Name = "Form1";
            this.Text = "REGION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_extract;
        private System.Windows.Forms.ComboBox cbox_options;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Label lbl_filename;
        private System.Windows.Forms.TextBox txtInput;
    }
}

