namespace StoryTellerWindowsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNameOfChild = new System.Windows.Forms.TextBox();
            this.lbNameOfChild = new System.Windows.Forms.Label();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.cbScary = new System.Windows.Forms.CheckBox();
            this.tbStoryText = new System.Windows.Forms.TextBox();
            this.btnTellStory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of Child";
            // 
            // tbNameOfChild
            // 
            this.tbNameOfChild.Location = new System.Drawing.Point(92, 10);
            this.tbNameOfChild.Name = "tbNameOfChild";
            this.tbNameOfChild.Size = new System.Drawing.Size(120, 20);
            this.tbNameOfChild.TabIndex = 1;
            // 
            // lbNameOfChild
            // 
            this.lbNameOfChild.AutoSize = true;
            this.lbNameOfChild.Location = new System.Drawing.Point(13, 46);
            this.lbNameOfChild.Name = "lbNameOfChild";
            this.lbNameOfChild.Size = new System.Drawing.Size(64, 13);
            this.lbNameOfChild.TabIndex = 2;
            this.lbNameOfChild.Text = "Age of Child";
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(92, 44);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(120, 20);
            this.numAge.TabIndex = 3;
            // 
            // cbScary
            // 
            this.cbScary.AutoSize = true;
            this.cbScary.Location = new System.Drawing.Point(16, 79);
            this.cbScary.Name = "cbScary";
            this.cbScary.Size = new System.Drawing.Size(80, 17);
            this.cbScary.TabIndex = 4;
            this.cbScary.Text = "Scary Story";
            this.cbScary.UseVisualStyleBackColor = true;
            // 
            // tbStoryText
            // 
            this.tbStoryText.Location = new System.Drawing.Point(16, 162);
            this.tbStoryText.Multiline = true;
            this.tbStoryText.Name = "tbStoryText";
            this.tbStoryText.Size = new System.Drawing.Size(256, 87);
            this.tbStoryText.TabIndex = 5;
            // 
            // btnTellStory
            // 
            this.btnTellStory.Location = new System.Drawing.Point(16, 122);
            this.btnTellStory.Name = "btnTellStory";
            this.btnTellStory.Size = new System.Drawing.Size(75, 23);
            this.btnTellStory.TabIndex = 6;
            this.btnTellStory.Text = "Tell story";
            this.btnTellStory.UseVisualStyleBackColor = true;
            this.btnTellStory.Click += new System.EventHandler(this.btnTellStory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnTellStory);
            this.Controls.Add(this.tbStoryText);
            this.Controls.Add(this.cbScary);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.lbNameOfChild);
            this.Controls.Add(this.tbNameOfChild);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "StorytellerApp";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNameOfChild;
        private System.Windows.Forms.Label lbNameOfChild;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.CheckBox cbScary;
        private System.Windows.Forms.TextBox tbStoryText;
        private System.Windows.Forms.Button btnTellStory;
    }
}

