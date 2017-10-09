using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeLib;

namespace EmployeeLibTests
{
    [TestClass]
    public class EmployeeTesting
    {
        [TestMethod]
        public void changeStringOrder()
        {
            string input = @"""Mattias Asplund"" 46 35000.00 070-6186120";

            Employee employeeOne = new Employee();
            employeeOne.Convert(input);
            Assert.AreEqual("Mattias", employeeOne.firstName.ToString());
            Assert.AreEqual("Asplund, Mattias (Lön: 35000,00 SEK) Telefon:070-6186120 Födelseår:1971", employeeOne.infoString());
        }
    }
}
