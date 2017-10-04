using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoyOrGirlApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txnPnr.Text.Count() != 13 && txnPnr.Text.Contains('-'))
            {
                MessageBox.Show("Fel format! Skriv in ditt personnummer såhär: YYYYMMDD-XXXX");
            }
            else
            MessageBox.Show($"{txbName.Text} med personnumret {txnPnr.Text} har könet {getGender(txnPnr.Text)}");
        }
        public string getGender(string personalnumber)
        {
            int last_number = Convert.ToInt32(personalnumber.Substring(11, 1));
            if (last_number % 2 > 0) // Inte jämt om vi får rest
                return "Man";
            else
                return "Kvinna"; // Jämt om vi inte får rest
        }
    }
}
