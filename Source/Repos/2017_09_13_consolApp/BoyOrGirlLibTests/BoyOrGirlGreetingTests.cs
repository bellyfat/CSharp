using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoyOrGirlLib;

namespace BoyOrGirlLibTests
{
    [TestClass]
    public class BoyOrGirlGreetingTests
    {
        [TestMethod]
        public void Man()
        {
            var sut = new BoyOrGirlGreeting("Moses", "Johansson", "19930604-2939");
            
            var expected = "Godmorgon Mr. Johansson";
            Assert.AreEqual(expected, sut.Greeting());
        }
        [TestMethod]
        public void Woman()
        {
            var sut = new BoyOrGirlGreeting("Maria", "Alfonsson", "19930604-2929");

            var expected = "Godmorgon Miss. Alfonsson";
            Assert.AreEqual(expected, sut.Greeting());
        }
    }
}
