using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiceMultiPlayerGameLib;
using System.Diagnostics;

namespace DiceGameMultiLibTests
{
    [TestClass]
    public class DiceMultiPlayerGameTests
    {
        [TestMethod]
        public void runGameFor10Minutes()
        {
            ITimeProvider fakeTimeProvider = new FakeTimeProvider();
            fakeTimeProvider.Now = DateTime.Now;
            DiceMultiPlayerGame sut = new DiceMultiPlayerGame(fakeTimeProvider);

            while (!sut.GameOver)
            {
                fakeTimeProvider.Now = fakeTimeProvider.Now.AddSeconds(1);
                Debug.WriteLine("hej");
            }
        }
    }

}
