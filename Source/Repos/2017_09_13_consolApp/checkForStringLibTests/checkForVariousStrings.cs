using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using checkForString;
using System.Diagnostics;

namespace checkForStringLibTests
{
    [TestClass]
    public class checkForVariousStrings
    {
        [TestMethod]
        public void checkRegexGroupsOfString()
        {
            string input = @"""Mattias Asplund"" 46 35000.00 070-6186120";

            checkWithRegex sut = new checkWithRegex(input);

            MatchCollection matches = sut.checkRegex();
            Assert.AreEqual("Mattias Asplund", matches[0].Groups[1].Value.ToString());
        }
    }
}
