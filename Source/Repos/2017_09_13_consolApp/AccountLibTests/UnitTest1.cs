using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountLibs;

namespace AccountLibTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sum()
        {
            Account assets = new Account { IsSummary = true };
        }
    }
}
