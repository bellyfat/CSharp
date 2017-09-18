using _2017_09_13_consolApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryTellerWindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTellStory_Click(object sender, EventArgs e)
        {
            try
            {
                Storyteller storyteller = new Storyteller();
                int age = Convert.ToInt32(numAge.Value);
                tbStoryText.Text = storyteller.TellStory(tbNameOfChild.Text, age, cbScary.Checked);
            }
            catch (InvalidOperationException ioe)
            {
                MessageBox.Show("Kan inte berätta storyn för dig.");
            }
            finally
            {

            }
        }
    }
}
