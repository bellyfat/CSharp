using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    public class Calculator
    {
        private string buffer = "";
        private List<int> numbers = new List<int>();
        public int results;
        public bool on = false;
        private string display = "0";


        public string Display
        {
            get
            {
                if (on)
                {
                    return display;
                }
                return null;
            }
            set {
                display = value;
            }
        }
      
        public void PowerOn()
        {
            on = true;
        }

        public void Press(string key)
        {

            if (key == "+")
            {
                var number = int.Parse(buffer);
                numbers.Add(number);
                buffer = "";
            }
            else if (key == "=")
            {
                var number = int.Parse(buffer);
                numbers.Add(number);
                buffer = "";
                Display = numbers.Sum().ToString();
            }
            else
            {
                buffer += key;
                Display = int.Parse(buffer).ToString();
            }
        }
    }
}
