using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using drivingLogLib;

namespace DrivingLogLibTests
{
    [TestClass]
    public class DrivingLogTests
    {
        // Fish level
        [TestMethod]
        public void MonthlyStatistics()
        {

            drivingLog sut = new drivingLog();
            sut.addEntry(Convert.ToDateTime("2017-01-01 00:00:00"), 22M, "Hämtade lösgodis");
            sut.addEntry(Convert.ToDateTime("2017-01-06 00:00:00"), 12M, "Hämtade lösgodis");
            sut.addEntry(Convert.ToDateTime("2017-03-01 00:00:00"), 10M, "Fraktade lastpallar till Testbolaget AB");

            decimal milesDriven = sut.MilesDriven(Convert.ToDateTime("2017-01-01 00:00:00"));
            Assert.AreEqual(34M, milesDriven);

        }
    }
}
