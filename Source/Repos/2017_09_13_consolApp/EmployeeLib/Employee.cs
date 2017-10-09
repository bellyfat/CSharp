using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public class Employee
    {
        public string firstName;
        public string secondName;
        public string PhoneNumber;
        public string birthdayAge;
        public decimal salary;

        public string Convert(string value)
        {
            string pattern = @"(\w+) ([^\""""]*)\""""? (\d{2}) (\d{5}.\d{2}) (\d{3}-\d{7})";

            GroupCollection matchGroups = Regex.Matches(value, pattern)[0].Groups;
            firstName = matchGroups[1].Value;
            secondName = matchGroups[2].Value;
            birthdayAge = matchGroups[3].Value;
            salary = decimal.Parse(matchGroups[4].Value, CultureInfo.InvariantCulture);
            PhoneNumber = matchGroups[5].Value;

            return infoString();
        }

        public string infoString()
        {
            // Asplund, Mattias (Lön: 35000,00 SEK) Telefon:070-6186120 Födelseår:1971
            return $"{secondName}, {firstName} (Lön: {Salary}) Telefon:{PhoneNumber} Födelseår:{BirthdayYear}";
        }
        public string Salary
        {
            get
            {
                Debug.WriteLine(this.salary.ToString());
                return this.salary.ToString("F2") + " SEK"; // F2 med två decimaler
            }
        }
        public string BirthdayYear
        {
            get
            {
                return (DateTime.Now.Year - int.Parse(birthdayAge)).ToString();
            }
        }
    }
}
