using GuessNumberLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumberWindowsForm
{
    public partial class Form1 : Form
    {
        private GuessNumber game = new GuessNumber();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            try
            {
                game.Guess(int.Parse(tbUserGuessNumber.Text));
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
            lblFeedback.Text = game.Feedback;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFeedback.Text = game.Feedback;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (game.Tries > 0 && game.GameOver != true)
            {
                DialogResult dialogResult = MessageBox.Show("Sure", "You'll lose current game. Sure?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    game.newGame();
                    lblFeedback.Text = game.Feedback;
                    tbUserGuessNumber.Text = string.Empty;
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Your game is still on!");
                }
            }
            if (game.GameOver == true)
            {
                game.newGame();
                lblFeedback.Text = game.Feedback;
                tbUserGuessNumber.Text = string.Empty;
            }
        }
    }
}
