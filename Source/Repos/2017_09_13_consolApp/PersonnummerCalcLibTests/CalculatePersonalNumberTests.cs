using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonnummerCalcLib;

namespace PersonnummerCalcLibTests
{
    [TestClass]
    public class CalculatePersonalNumberTests
    {
        /*
         
            7  1  0  4  0  5  -  7  8  5   

            2  1  2  1  2  1     2  1  2

            14 1  0  4  0  5    14  8 10
 
            5  1  0  4  0  5     5  8  1

            test:

            9  3  0  6  0  4    2  9  3  (9)

            2  1  2  1  2  1    2  1  2

            18 3  0  6  0  4 -  4  9  6

            9  3  0   6  0  4 - 4  9  6 = 41?

            Last number: 50 - 41 = 9

             */
        [TestMethod]
        public void Calculate9DigitSocialNumberMoses()
        {
            int[] socialnumber = { 9, 3, 0, 6, 0, 4, 2, 9, 3 };
            var sut = new CalculatePersonalNumber(socialnumber);
            int expectedLastDigit = 9;
            Assert.AreEqual(expectedLastDigit, sut.getLastDigit());
        }
        [TestMethod]
        public void Calculate9DigitSocialNumberAmin()
        {
            //86 01 12 15 13 
            int[] socialnumber = { 8, 6, 0, 1, 1, 2, 1, 5, 1 };
            var sut = new CalculatePersonalNumber(socialnumber);
            int expectedLastDigit = 3;
            Assert.AreEqual(expectedLastDigit, sut.getLastDigit());
        }
    }
}
