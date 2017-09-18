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
        [TestMethod]
        public void TestCircusWithFireEntertainers()
        {
            // Arrange
            Circus sut = new Circus("Elefanten");
            Artist clown = new Artist("Clownen Surskratt");
            Artist lindansare = new Artist("Linsdansaren Repo");
            Artist firebreather = new Artist("Eldsprutare Peter");
            Artist fireentertainer = new Artist("Eldunderhållare Magnus");
            sut.Employ(clown);
            sut.Employ(lindansare);
            sut.Employ(firebreather);
            sut.Employ(fireentertainer);
            sut.ArtistPerformance(clown);
            sut.ArtistPerformance(lindansare);
            sut.ArtistPerformance(lindansare);
            sut.ArtistPerformance(firebreather);
            string expected = "Cirkusen Elefanten har 4 artister. Clownen Surskratt har uppträtt 1 gång. Linsdansaren Repo har uppträtt 2 gånger. Eldsprutare Peter har uppträtt 1 gång. Eldunderhållare Magnus har uppträtt 0 gånger.";
            
            // Act
            string actual = sut.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCircusWithManyPerformancesAndFewArtists()
        {
            // Arrange
            Circus sut = new Circus("Kulan");
            Artist canon = new Artist("Kanongubben");

            Artist rabbithatperson = new Artist("Mannen med stor hatt och kanin");
            sut.Employ(canon);
            sut.Employ(rabbithatperson);

            sut.ArtistPerformance(canon);
            sut.ArtistPerformance(canon);
            sut.ArtistPerformance(canon);
            sut.ArtistPerformance(canon);
            sut.ArtistPerformance(canon);

            sut.ArtistPerformance(rabbithatperson);

            sut.ArtistPerformance(canon);
            sut.ArtistPerformance(canon);
            sut.ArtistPerformance(canon);
            sut.ArtistPerformance(canon);
            sut.ArtistPerformance(canon);
            sut.ArtistPerformance(canon);

            string expected = "Cirkusen Kulan har 2 artister. Kanongubben har uppträtt 11 gånger. Mannen med stor hatt och kanin har uppträtt 1 gång.";

            // Act
            string actual = sut.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
