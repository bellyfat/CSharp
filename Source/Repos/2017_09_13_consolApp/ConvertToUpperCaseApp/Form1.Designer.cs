namespace ConvertToUpperCaseApp
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
            this.fileOneDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveThirdFile = new System.Windows.Forms.SaveFileDialog();
            this.btnSelectFileOne = new System.Windows.Forms.Button();
            this.fileTwoDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectFileTwo = new System.Windows.Forms.Button();
            this.lbSelectFileOne = new System.Windows.Forms.Label();
            this.lbSelectFileTwo = new System.Windows.Forms.Label();
            this.btnSaveContent = new System.Windows.Forms.Button();
            this.cbbListTxtFiles = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnFolderSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectFileOne
            // 
            this.btnSelectFileOne.Location = new System.Drawing.Point(13, 60);
            this.btnSelectFileOne.Name = "btnSelectFileOne";
            this.btnSelectFileOne.Size = new System.Drawing.Size(125, 23);
            this.btnSelectFileOne.TabIndex = 0;
            this.btnSelectFileOne.Text = "Choose file one";
            this.btnSelectFileOne.UseVisualStyleBackColor = true;
            this.btnSelectFileOne.Click += new System.EventHandler(this.chooseFiles_Click);
            // 
            // btnSelectFileTwo
            // 
            this.btnSelectFileTwo.Location = new System.Drawing.Point(13, 90);
            this.btnSelectFileTwo.Name = "btnSelectFileTwo";
            this.btnSelectFileTwo.Size = new System.Drawing.Size(125, 23);
            this.btnSelectFileTwo.TabIndex = 1;
            this.btnSelectFileTwo.Text = "Choose file two";
            this.btnSelectFileTwo.UseVisualStyleBackColor = true;
            this.btnSelectFileTwo.Click += new System.EventHandler(this.btnSelectFileTwo_Click);
            // 
            // lbSelectFileOne
            // 
            this.lbSelectFileOne.AutoSize = true;
            this.lbSelectFileOne.Location = new System.Drawing.Point(160, 70);
            this.lbSelectFileOne.Name = "lbSelectFileOne";
            this.lbSelectFileOne.Size = new System.Drawing.Size(80, 13);
            this.lbSelectFileOne.TabIndex = 2;
            this.lbSelectFileOne.Text = "No file selected";
            // 
            // lbSelectFileTwo
            // 
            this.lbSelectFileTwo.AutoSize = true;
            this.lbSelectFileTwo.Location = new System.Drawing.Point(160, 99);
            this.lbSelectFileTwo.Name = "lbSelectFileTwo";
            this.lbSelectFileTwo.Size = new System.Drawing.Size(80, 13);
            this.lbSelectFileTwo.TabIndex = 3;
            this.lbSelectFileTwo.Text = "No file selected";
            // 
            // btnSaveContent
            // 
            this.btnSaveContent.Location = new System.Drawing.Point(13, 120);
            this.btnSaveContent.Name = "btnSaveContent";
            this.btnSaveContent.Size = new System.Drawing.Size(125, 23);
            this.btnSaveContent.TabIndex = 4;
            this.btnSaveContent.Text = "Save contents to file";
            this.btnSaveContent.UseVisualStyleBackColor = true;
            this.btnSaveContent.Visible = false;
            this.btnSaveContent.Click += new System.EventHandler(this.btnSaveContent_Click);
            // 
            // cbbListTxtFiles
            // 
            this.cbbListTxtFiles.FormattingEnabled = true;
            this.cbbListTxtFiles.Location = new System.Drawing.Point(151, 156);
            this.cbbListTxtFiles.Name = "cbbListTxtFiles";
            this.cbbListTxtFiles.Size = new System.Drawing.Size(121, 21);
            this.cbbListTxtFiles.TabIndex = 5;
            // 
            // btnFolderSelect
            // 
            this.btnFolderSelect.Location = new System.Drawing.Point(151, 127);
            this.btnFolderSelect.Name = "btnFolderSelect";
            this.btnFolderSelect.Size = new System.Drawing.Size(75, 23);
            this.btnFolderSelect.TabIndex = 6;
            this.btnFolderSelect.Text = "Open Folder";
            this.btnFolderSelect.UseVisualStyleBackColor = true;
            this.btnFolderSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnFolderSelect);
            this.Controls.Add(this.cbbListTxtFiles);
            this.Controls.Add(this.btnSaveContent);
            this.Controls.Add(this.lbSelectFileTwo);
            this.Controls.Add(this.lbSelectFileOne);
            this.Controls.Add(this.btnSelectFileTwo);
            this.Controls.Add(this.btnSelectFileOne);
            this.Name = "Form1";
            this.Text = "Text from files to file";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog fileOneDialog;
        private System.Windows.Forms.SaveFileDialog SaveThirdFile;
        private System.Windows.Forms.Button btnSelectFileOne;
        private System.Windows.Forms.OpenFileDialog fileTwoDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelectFileTwo;
        private System.Windows.Forms.Label lbSelectFileOne;
        private System.Windows.Forms.Label lbSelectFileTwo;
        private System.Windows.Forms.Button btnSaveContent;
        private System.Windows.Forms.ComboBox cbbListTxtFiles;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnFolderSelect;
    }
}

