using DiceGameLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGameWindowsForms
{
    public partial class Form1 : Form
    {
        DiceGame dicegame = new DiceGame(new Random());
        public Form1()
        {
            InitializeComponent();
            lbFeedback.Text = dicegame.Feedback;
        }

        private void btnThrowDices_Click(object sender, EventArgs e)
        {
            dicegame.ThrowDices();
            lbFeedback.Text = dicegame.Feedback;
        }
    }
}
