using PersonnummerCalcLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonnummerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string personnummerWithoutLast = textBox1.Text;
            if (personnummerWithoutLast.Count() == 9 && Regex.IsMatch(personnummerWithoutLast, @"^\d+$"))
            {
                char[] personnumArrChars = personnummerWithoutLast.ToCharArray();

                int[] personnumArr = new int[personnumArrChars.Count()];
                for (int d = 0; d < personnumArrChars.Count(); d++)
                {
                    personnumArr[d] = Convert.ToInt32(personnumArrChars[d].ToString());
                }

                CalculatePersonalNumber calcPersonNum = new CalculatePersonalNumber(personnumArr);
                MessageBox.Show($"Ditt sista nummer är: {calcPersonNum.getLastDigit()}");
            }
            else
                MessageBox.Show("Fel inmatning. Kom ihåg att värdet ska vara YYMMDDXXX");
        }

    }
}
