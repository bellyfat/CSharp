using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartApp;

namespace ShoppingCartTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConfirmOrder()
        {
            // Arrange
            Customer testCustomer = new Customer("Peter", "Andersson");
            Product testLaptop = new Product("laptop");
            testLaptop.Price = 400;

            Product testScreen = new Product("modern skärm");
            testScreen.Price = 1500;

            ShoppingCart sut = new ShoppingCart();

            sut.Customer = testCustomer;
            sut.AddProduct(testLaptop);
            sut.AddProduct(testScreen);

            string expected = "Peter Andersson har beställt varor för 1900 SEK";

            // Act
            sut.Order();
            OrderConfirmation result = sut.OrderConfirm;
            string actual = result.Message;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
