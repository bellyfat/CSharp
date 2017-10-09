using System;
using System.Collections.Generic;
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
        public string salary;

        public string Convert(string value)
        {
            string pattern = @"(\w+) ([^\""""]*)\""""? (\d{2}) (\d{5}.\d{2}) (\d{3}-\d{7})";

            GroupCollection matchGroups = Regex.Matches(value, pattern)[0].Groups;
            firstName = matchGroups[1].Value;
            secondName = matchGroups[2].Value;
            birthdayAge = matchGroups[3].Value;
            salary = (matchGroups[4].Value).ToString();
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
                return this.salary.Replace('.', ',') + " SEK";
            }
        }
        public string BirthdayYear
        {
            get
            {
                return (DateTime.Today.Year - int.Parse(birthdayAge)).ToString();
            }
        }
    }
}
