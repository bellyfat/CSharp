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
        [TestMethod]
        public void ReadFile()
        {
            string filename = "MATTIAS0_SIE4 2015-09-01 - 2016-08-31.SE.txt";
            File.OpenRead(filename);
        }
        [TestMethod]
        public void TotalNumberOfTransactionRows()
        {
            string filename = "MATTIAS0_SIE4 2015-09-01 - 2016-08-31.SE.txt";
            string regexPattern = @"(#TRANS \d{4}\D{4})(.{0,100})";
            SIEReading siereading = new SIEReading(filename, regexPattern);
            Debug.WriteLine(siereading.TotalRowsFromPattern(regexPattern));
        }
        [TestMethod]
        public void TotalSumOfTransactions()
        {
            string filename = "MATTIAS0_SIE4 2015-09-01 - 2016-08-31.SE.txt";
            string regexPattern = @"(#TRANS \d{4}\D{4})(.{0,100})";
            SIEReading siereading = new SIEReading(filename, regexPattern);
            Debug.WriteLine(siereading.TotalSumFromPattern());
        }
    }
}
