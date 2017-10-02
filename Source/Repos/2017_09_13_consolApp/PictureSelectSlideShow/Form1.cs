using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureSelectSlideShow
{
    public partial class Form1 : Form
    {
        private int filenumber = 0;
        private List<Picture> files = new List<Picture>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            for (int i = 0; i < openFileDialog1.FileNames.Count(); i++)
            {
                files.Add( 
                new Picture
                {
                    url = openFileDialog1.FileNames[i]
                });
            }
            timer1.Enabled = true;
            pictureBox1.ImageLocation = files[0].url;
            pictureBox1.Load();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            filenumber++;
            if (filenumber >= files.Count())
                filenumber = 0;

            DisplayFileNumber(filenumber);
        }
        private void DisplayFileNumber(int num)
        {
             pictureBox1.Load(files[num].url);            
        }
    }
}
