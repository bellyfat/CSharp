using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIEImportLib;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Globalization;

namespace SIEImportTest
{
    [TestClass]
    public class SIEImportTester
    {
        private const string FileName = @"C:\Users\Studerande\Source\Repos\2017_09_13_consolApp\SIEImportLib\MATTIAS0_SIE4 2015-09-01 - 2016-08-31.SE.txt";
        private Dictionary<string, decimal> accounts = new Dictionary<string, decimal>();
        [TestMethod]
        public void CanRead()
        {
            StreamReader streamreader;
            if (File.Exists(FileName))
            {
                try
                {
                    streamreader = File.OpenText(FileName);
                    while (true)
                    {
                        string line = streamreader.ReadLine();
                        if (line == null)
                            break;
                        string pattern = @"#TRANS (\d{4}) {.*} (-?\d*.\d*)";
                        Match match = Regex.Match(line, pattern);
                        if (match.Success)
                        {
                            string accountId = match.Groups[1].Value;
                            decimal amount = decimal.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture);
                            if (accounts.ContainsKey(accountId))
                                accounts[accountId] += amount;
                            else
                                accounts[accountId] = amount;
                        }
                        foreach (var entry in accounts.OrderBy(entry => entry.Key))
                            Debug.WriteLine($"{entry.Key} {entry.Value.ToString("F2")}");
                        Debug.WriteLine(accounts.Sum(entry => entry.Value));
                    }
                }
                catch (IOException ioe)
                {
                    Debug.WriteLine(ioe.StackTrace);
                }
            }
            else
                throw new FileNotFoundException();
        }
    }
   }

