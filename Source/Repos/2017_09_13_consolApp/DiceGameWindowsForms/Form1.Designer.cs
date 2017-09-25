namespace DiceGameWindowsForms
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
            this.btnThrowDices = new System.Windows.Forms.Button();
            this.lbFeedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThrowDices
            // 
            this.btnThrowDices.Location = new System.Drawing.Point(14, 12);
            this.btnThrowDices.Name = "btnThrowDices";
            this.btnThrowDices.Size = new System.Drawing.Size(274, 56);
            this.btnThrowDices.TabIndex = 0;
            this.btnThrowDices.Text = "Throw Dices";
            this.btnThrowDices.UseVisualStyleBackColor = true;
            this.btnThrowDices.Click += new System.EventHandler(this.btnThrowDices_Click);
            // 
            // lbFeedback
            // 
            this.lbFeedback.Location = new System.Drawing.Point(12, 82);
            this.lbFeedback.MaximumSize = new System.Drawing.Size(400, 400);
            this.lbFeedback.MinimumSize = new System.Drawing.Size(200, 100);
            this.lbFeedback.Name = "lbFeedback";
            this.lbFeedback.Size = new System.Drawing.Size(277, 100);
            this.lbFeedback.TabIndex = 1;
            this.lbFeedback.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 196);
            this.Controls.Add(this.lbFeedback);
            this.Controls.Add(this.btnThrowDices);
            this.Name = "Form1";
            this.Text = "Throw Dice Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThrowDices;
        private System.Windows.Forms.Label lbFeedback;
    }
}

