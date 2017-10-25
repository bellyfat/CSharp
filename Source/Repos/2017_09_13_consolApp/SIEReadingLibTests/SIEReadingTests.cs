using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using SIEReadingLib;
using System.Diagnostics;

namespace SIEReadingLibTests
{
    [TestClass]
    public class SIEReadingTests
    {
        private StreamReader sr;
        [TestMethod]
        public void ReadFile()
        {
            string filename = "MATTIAS0_SIE4 2015-09-01 - 2016-08-31.SE.txt";
            string content = File.ReadAllText(filename);

            File.OpenRead(filename);
        }
        [TestMethod]
        public void TotalNumberOfTransactionRows()
        {
            string filename = "MATTIAS0_SIE4 2015-09-01 - 2016-08-31.SE.txt";
            string content = File.ReadAllText(filename);

            string regexPattern = @"(#TRANS \d{4}\D{4})(.{0,100})";
            SIEReading siereading = new SIEReading(content, regexPattern);
            Assert.AreEqual(498, siereading.TotalRowsFromPattern(regexPattern));
        }
        [TestMethod]
        public void TotalSumOfTransactionsIsZero()
        {
            string filename = "MATTIAS0_SIE4 2015-09-01 - 2016-08-31.SE.txt";
            string content = File.ReadAllText(filename);

            string regexPattern = @"(#TRANS \d{4}\D{4})(.{0,100})";
            SIEReading siereading = new SIEReading(content, regexPattern);
            Assert.AreEqual(0, siereading.TotalSumFromPattern());
        }
        [TestMethod]
        public void NumberOfTransactionsAccounts()
        {
            string filename = "MATTIAS0_SIE4 2015-09-01 - 2016-08-31.SE.txt";
            string content = File.ReadAllText(filename);

            // string regexPattern = @"(#TRANS \d{4}\D{4})(.{0,100})";
            string regexPattern = @"(#TRANS 6540\D{4})(.{0,100})";

            SIEReading siereading = new SIEReading(content, regexPattern);
            Debug.WriteLine(siereading.Accounts.Count);
        }
        [TestMethod]
        public void TransTotalOfAccount1790()
        {
            string filename = "MATTIAS0_SIE4 2015-09-01 - 2016-08-31.SE.txt";
            string content = File.ReadAllText(filename);

            SIEReading siereading = new SIEReading(content);
            //Assert.AreEqual(25, siereading.SumFromAccountNumber(1790));
        }
        [TestMethod]
        public void TransOfAccounts()
        {
            string filename = "MATTIAS0_SIE4 2015-09-01 - 2016-08-31.SE.txt";
            string content = File.ReadAllText(filename);

            SIEReading siereading = new SIEReading(content);
            siereading.AssignAccountsTotals();
            foreach (var dict in siereading.accountsDictionary)
            {
                Debug.WriteLine(dict.Key + " " + dict.Value);
            }
            
        }
    }
}
