namespace CustomerForm
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
            this.txbName = new System.Windows.Forms.TextBox();
            this.datetmBirthday = new System.Windows.Forms.DateTimePicker();
            this.txbTelNr = new System.Windows.Forms.TextBox();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.lstbxCustomersPreview = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(97, 29);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 20);
            this.txbName.TabIndex = 0;
            // 
            // datetmBirthday
            // 
            this.datetmBirthday.Location = new System.Drawing.Point(97, 60);
            this.datetmBirthday.Name = "datetmBirthday";
            this.datetmBirthday.Size = new System.Drawing.Size(200, 20);
            this.datetmBirthday.TabIndex = 1;
            // 
            // txbTelNr
            // 
            this.txbTelNr.Location = new System.Drawing.Point(97, 86);
            this.txbTelNr.Name = "txbTelNr";
            this.txbTelNr.Size = new System.Drawing.Size(100, 20);
            this.txbTelNr.TabIndex = 2;
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(29, 112);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(120, 23);
            this.btnSaveToFile.TabIndex = 3;
            this.btnSaveToFile.Text = "Save information";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(26, 36);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Namn";
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Location = new System.Drawing.Point(26, 93);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(37, 13);
            this.lbTel.TabIndex = 5;
            this.lbTel.Text = "Tel nr.";
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Location = new System.Drawing.Point(26, 66);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(62, 13);
            this.lbBirthday.TabIndex = 6;
            this.lbBirthday.Text = "Födelsedag";
            // 
            // lstbxCustomersPreview
            // 
            this.lstbxCustomersPreview.FormattingEnabled = true;
            this.lstbxCustomersPreview.Location = new System.Drawing.Point(12, 180);
            this.lstbxCustomersPreview.Name = "lstbxCustomersPreview";
            this.lstbxCustomersPreview.Size = new System.Drawing.Size(318, 69);
            this.lstbxCustomersPreview.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Existing customers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbxCustomersPreview);
            this.Controls.Add(this.lbBirthday);
            this.Controls.Add(this.lbTel);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.txbTelNr);
            this.Controls.Add(this.datetmBirthday);
            this.Controls.Add(this.txbName);
            this.Name = "Form1";
            this.Text = "Save customer file";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.DateTimePicker datetmBirthday;
        private System.Windows.Forms.TextBox txbTelNr;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.ListBox lstbxCustomersPreview;
        private System.Windows.Forms.Label label1;
    }
}

