using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EducationLib;

namespace EducationLibTests
{
    [TestClass]
    public class RecursiveTests
    {   
        [TestMethod]
        public void TotalHoursOfEducationEvents()
        {
            Event spo16education = new Event("SPO16", "SharePoint Programutveckling", true);
            Event courseDay = new Event("Introduktion", "Sal B", false);
            Event courseDay2 = new Event("Programmering heldag", "Sal A", false);

            spo16education.Children.Add(courseDay);
            spo16education.Children.Add(courseDay2);
            
            Assert.AreEqual(12, spo16education.Duration);
        }
    }
}
