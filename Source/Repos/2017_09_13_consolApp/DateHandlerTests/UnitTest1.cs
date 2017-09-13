using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2017_09_13_consolApp;

namespace DateHandlerTests
{
  [TestClass]
    public class DateHandlerTests
    {
        [TestMethod]
        public void DaysBetween20170101And20190320()
        {
            var sut = new DateHandler();
            var firstDate = new DateTime(2017, 1, 1);
            var secondDate = new DateTime(2019, 3, 20);
            int days = sut.DaysBetweenDates(firstDate, secondDate);
            Assert.AreEqual(808, days);
        }
        [TestMethod]
        public void Add1000DaysTo20170101()
        {
            var sut = new DateHandler();
            var theDate = new DateTime(2017, 1, 1);
            DateTime endDate = sut.Add1000Days(theDate);
            Assert.AreEqual(new DateTime(2019, 9, 28), endDate);
        }
    }
}
