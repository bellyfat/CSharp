using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertToUpperCaseApp
{
    public partial class Form1 : Form
    {
        private bool FileUploadError = false;
        public Form1()
        {
            InitializeComponent();
        }

        public void ValidateSelectUpload(OpenFileDialog openfiledialog)
        {
            if (Path.GetExtension(openfiledialog.FileName) != "txt")
            { 
                this.FileUploadError = true;
                openfiledialog.FileName = "";
                MessageBox.Show("Filen kan endast vara txt");
            }
            else
                this.FileUploadError = false;
        }

        private void chooseFiles_Click(object sender, EventArgs e)
        {
            fileOneDialog.ShowDialog();
            lbSelectFileOne.Text = fileOneDialog.FileName;
            if (fileOneDialog.FileName != "" && fileTwoDialog.FileName != "")
                btnSaveContent.Visible = true;

            ValidateSelectUpload(fileOneDialog);
        }

        private void btnSelectFileTwo_Click(object sender, EventArgs e)
        {
            fileTwoDialog.ShowDialog();
            lbSelectFileTwo.Text = fileTwoDialog.FileName;
            if(fileOneDialog.FileName != "" && fileTwoDialog.FileName != "")
            btnSaveContent.Visible = true;

            ValidateSelectUpload(fileTwoDialog);
        }

        private void btnSaveContent_Click(object sender, EventArgs e)
        {
            if(this.FileUploadError == false)
            { 
                SaveThirdFile.ShowDialog();

                if (File.Exists(fileOneDialog.FileName) && File.Exists(fileTwoDialog.FileName))
                {
                    try
                    {
                        string contents = File.ReadAllText(fileOneDialog.FileName) + File.ReadAllText(fileTwoDialog.FileName);
                        File.AppendAllText(SaveThirdFile.FileName, contents);
                        MessageBox.Show("Content made into one file txt file.");
                    }
                    catch (IOException ioe)
                    {
                        MessageBox.Show(ioe.StackTrace);
                    }
                }
                else
                {
                    MessageBox.Show("Error. Please make sure you have selected two txt files");
                }
            }
        }
    }
}
