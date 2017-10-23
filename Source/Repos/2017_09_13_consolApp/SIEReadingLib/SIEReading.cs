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
        private string filename;
        private string pattern;
        public int matchingrows = 0;
        public int MatchingRows
        {
            get
            {
                StreamReader sr;
                sr = File.OpenText(filename);

                while (true)
                {
                    string line = sr.ReadLine();
                    if (line == null)
                        break;

                    Match match = Regex.Match(line, pattern);
                    if (match.Success)
                        matchingrows++;
                }
                return matchingrows;
            }
        }
        List<double> transactions = new List<double>();
        
        public SIEReading(string filename, string pattern)
        {
            this.filename = filename;
            this.pattern = pattern;
        }
        public int TotalRowsFromPattern(string pattern)
        {
            StreamReader sr;
            sr = File.OpenText(filename);

            while (true)
            {
                string line = sr.ReadLine();
                if(line == null)
                break;

                Match match = Regex.Match(line, pattern);
                if(match.Success)
                matchingrows++;
            }
            return matchingrows;
        }
        public double TotalSumFromPattern()
        {
            StreamReader sr;
            sr = File.OpenText(filename);

            while (true)
            {
                string line = sr.ReadLine();
                if (line == null)
                    break;

                Match match = Regex.Match(line, pattern);
                if (match.Success)
                {
                    string convertedLine;
                    convertedLine = match.Groups[2].Value.Replace('.', ',');
                    transactions.Add(Convert.ToDouble(convertedLine));
                }
            }
            return transactions.Sum();
        }
    }
}
