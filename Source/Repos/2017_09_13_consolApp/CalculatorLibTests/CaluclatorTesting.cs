using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLib;
using System.Diagnostics;

namespace CalculatorLibTests
{
    [TestClass]
    public class CaluclatorTesting
    {
        [TestMethod]
        public void EmptyDisplay()
        {
            // Arrange
            Calculator sut = new Calculator();
            // Act
            sut.PowerOn();
            // Assert
            Assert.AreEqual("0", sut.Display);
        }
        [TestMethod]
        public void OneDigitDisplay()
        {
            // Arrange
            Calculator sut = new Calculator();
            // Act
            sut.PowerOn();
            sut.Press("7");
            // Assert
            Assert.AreEqual("7", sut.Display);
        }
        [TestMethod]
        public void TwoDigitDisplay()
        {
            // Arrange
            Calculator sut = new Calculator();
            // Act
            sut.PowerOn();
            sut.Press("5");
            sut.Press("7");
            // Assert
            Assert.AreEqual("57", sut.Display);
        }
        [TestMethod]
        public void Add12And25()
        {
            // Arrange
            Calculator sut = new Calculator();

            // Act
            sut.PowerOn();
            Debug.WriteLine(sut.Display);
            sut.Press("1");
            Debug.WriteLine(sut.Display);
            sut.Press("2");
            Debug.WriteLine(sut.Display);
            sut.Press("+");
            Debug.WriteLine(sut.Display);
            sut.Press("2");
            Debug.WriteLine(sut.Display);
            sut.Press("5");
            Debug.WriteLine(sut.Display);
            sut.Press("=");
            Debug.WriteLine(sut.Display);

            // Assert
            Assert.AreEqual("37", sut.Display);
        }
    }
}
