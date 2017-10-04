using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoyOrGirlLib
{
    public class BoyOrGirlGreeting
    {
        private string firstname;
        private string secondname;
        private string personnummer;



        public BoyOrGirlGreeting(string firstname, string secondname, string personnummer)
        {
            this.firstname = firstname;
            this.secondname = secondname;
            this.personnummer = personnummer;
        }
        public string Greeting()
        {
            return $"Godmorgon {getGender(this.personnummer)} {this.secondname}";
        }
        public string getGender(string personalnumber)
        {
            int last_number = Convert.ToInt32(personalnumber.Substring(11, 1));
            if (last_number % 2 > 0) // Inte jämt om vi får rest
                return "Mr.";
            else
                return "Miss."; // Jämt om vi inte får rest
        }
    }
}
