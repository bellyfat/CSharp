using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIEImportLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SIEImportTest
{
    [TestClass]
    public class RegexMatchCounterTests
    {
        [TestMethod]
        public void getNumberOfRowsOfFile()
        {
            const string content = @"C:\Users\Studerande\Source\Repos\2017_09_13_consolApp\SIEImportLib\MATTIAS0_SIE4 2015-09-01 - 2016-08-31.SE.txt";
            string regexPattern = @"#VER";
            RegexMatchCounter regexmatchcounter = new RegexMatchCounter();
            int lineCount = regexmatchcounter.CountMatchingLines(content, regexPattern);
            Debug.WriteLine(lineCount);
        }
        [TestMethod]
        public void getNumberOfRowsOfFileWithRegex()
        {
            const string content = @"C:\Users\Studerande\Source\Repos\2017_09_13_consolApp\SIEImportLib\MATTIAS0_SIE4 2015-09-01 - 2016-08-31.SE.txt";
            string regexPattern = @"#VER";
            StreamReader sr = File.OpenText(content);
            int rows = 0;
            while (true)
            {
                string line = sr.ReadLine();
                if (line == null)
                    break;

                Match match = Regex.Match(line, regexPattern);
                if (match.Success)
                    rows++;
            }
            Assert.AreEqual(165, rows);
        }
        [TestMethod]
        public void getNumberOfRowsOfFileWithLinq()
        {
            const string content = @"C:\Users\Studerande\Source\Repos\2017_09_13_consolApp\SIEImportLib\MATTIAS0_SIE4 2015-09-01 - 2016-08-31.SE.txt";
            string pattern = @"#VER";
            string[] lines = File.ReadAllLines(content);

            Assert.AreEqual(165, lines.Where(l => l.Contains(pattern)).ToArray().Count());
        }

        [TestMethod]
        public void getNumberOfRowsWithLinqAndRegex()
        {
            string content = @"C:\Users\Studerande\Source\Repos\2017_09_13_consolApp\SIEImportLib\MATTIAS0_SIE4 2015-09-01 - 2016-08-31.SE.txt";
            string regexPattern = @"#VER";
            string[] lines = File.ReadAllLines(content);
            Assert.AreEqual(165, lines.Where(l => Regex.Match(l, regexPattern).Success).ToArray().Length);
        }
        [TestMethod]
        public void getNumberOfRowsWithRegexMatches()
        {
            var contents = File.ReadAllText(@"C:\Users\Studerande\Source\Repos\2017_09_13_consolApp\SIEImportLib\MATTIAS0_SIE4 2015-09-01 - 2016-08-31.SE.txt");
            string regexPattern = @"#VER";
            RegexOptions options = RegexOptions.Multiline;
            Assert.AreEqual(165, Regex.Matches(contents, regexPattern, options).Count);
        
        }
    }
}
