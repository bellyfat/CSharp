using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SIEReadingLib
{
    public class SIEReading
    {
        private string content;
        private string pattern;
        public int matchingrows = 0;

        public Dictionary<int, double> accountsDictionary = new Dictionary<int, double>();

        public SIEReading(string content, string pattern)
        {
            this.content = content;
            this.pattern = pattern;
        }

        public SIEReading(string content)
        {
            this.content = content;
        }

        public List<int> Accounts
        {
            get
            {
                List<int> accounts = new List<int>();
                string patternForAccounts = @"(\w{5}) (\d{4})";

                RegexOptions options = RegexOptions.Multiline;
                Regex regex = new Regex(patternForAccounts, options);
                MatchCollection match = regex.Matches(content);

                //Match match = Regex.Match(line, patternForAccounts);
                for (int x = 0; x < match.Count; x++)
                {
                    if (match[x].Success)
                        accounts.Add(Convert.ToInt32(match[x].Groups[2].Value));
                }
                return accounts.Distinct().ToList();
            }
        }
        public int MatchingRows
        {
            get
            {
                RegexOptions options = RegexOptions.Multiline;
                Regex regex = new Regex(pattern, options);
                MatchCollection match = regex.Matches(content);

                for (int x = 0; x < match.Count; x++)
                {
                    if (match[x].Success)
                    {
                        matchingrows++;
                    }
                }

                return matchingrows;
            }
        }
        List<double> transactions = new List<double>();

        public int TotalRowsFromPattern(string pattern)
        {
            RegexOptions options = RegexOptions.Multiline;
            Regex regex = new Regex(pattern, options);
            MatchCollection match = regex.Matches(content);

            for (int x = 0; x < match.Count; x++)
            {
                if (match[x].Success)
                {
                    matchingrows++;
                }
            }
         
            return matchingrows;
        }
        public double TotalSumFromPattern()
        {
            {
                RegexOptions options = RegexOptions.Multiline;
                Regex regex = new Regex(pattern, options);
                MatchCollection match = regex.Matches(content);
                
                for (int x = 0; x < match.Count; x++)
                {
                    if (match[x].Success)
                    {
                        string convertedLine;
                        convertedLine = match[x].Groups[2].Value.Replace('.', ',');
                        transactions.Add(Convert.ToDouble(convertedLine));
                    }
                }

                return transactions.Sum();
            }
        }
        public double SumFromAccountNumber(int accountNumber)
        {
            string pattern = @"#TRANS XXXXXXX {} (.{0,100})".Replace("XXXXXXX", accountNumber.ToString());
            List<double> totalAccountTransValue = new List<double>();

            RegexOptions options = RegexOptions.Multiline;
            Regex regex = new Regex(pattern, options);
            MatchCollection match = regex.Matches(content);
            
            for (int x = 0; x < match.Count; x++)
            {
                if (match[x].Success)
                {
                    totalAccountTransValue.Add(Convert.ToDouble(match[x].Groups[1].Value.Replace('.', ',')));
                }
            }

            return totalAccountTransValue.Sum();
        }
        public void AssignAccountsTotals()
        {
            for (int x = 0; x < Accounts.Count; x++)
            {
                accountsDictionary.Add(Accounts[x], SumFromAccountNumber(Accounts[x]));
            }
        }
    }
}
