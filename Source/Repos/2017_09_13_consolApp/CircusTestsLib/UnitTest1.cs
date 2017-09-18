using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircusLib;

namespace CircusTestsLib
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCircus()
        {
            // Arrange
            Circus sut = new Circus("Elefanten");
            Artist clown = new Artist("Clownen Surskratt");
            Artist lindansare = new Artist("Linsdansaren Repo");
            sut.Employ(clown);
            sut.Employ(lindansare);
            sut.ArtistPerformance(clown);
            sut.ArtistPerformance(lindansare);
            sut.ArtistPerformance(lindansare);
            string expected = "Cirkusen Elefanten har 2 artister. Clownen Surskratt har uppträtt 1 gång. Linsdansaren Repo har uppträtt 2 gånger.";
            

            // Act
            string actual = sut.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
