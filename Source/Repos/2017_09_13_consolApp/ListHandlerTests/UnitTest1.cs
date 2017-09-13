using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2017_09_13_consolApp;

namespace ListHandlerTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddFiveStrings()
        {
            ListHandler sut = new ListHandler();
            sut.AddFiveStrings();
            Assert.AreEqual(5, sut.List.Count);
        }
        [TestMethod]
        public void RemoveThirdString()
        {
            ListHandler sut = new ListHandler();
            sut.AddFiveStrings();
            string fourthString = sut.List[3];
            sut.RemoveThirdString();
            Assert.AreEqual(4, sut.List.Count);
            Assert.AreEqual(fourthString, sut.List[2]);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ArgumentOutOfRange()
        {
            ListHandler sut = new ListHandler();
            sut.AddFiveStrings();
            sut.RemoveThirdString();
            Console.WriteLine(sut.List[4]);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Sort()
        {
            ListHandler sut = new ListHandler();
            sut.List.Add("Cesar");
            sut.List.Add("Bertil");
            sut.List.Add("Adam");
            sut.Sort();
            Assert.AreEqual("Adam", sut.List[0]);
        }
    }
}
