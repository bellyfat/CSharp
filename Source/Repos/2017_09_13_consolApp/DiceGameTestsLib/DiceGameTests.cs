using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiceGameLib;
using System.Diagnostics;

namespace DiceGameTestsLib
{
    [TestClass]
    public class DiceGameTests
    {
        [TestMethod]
        public void ThrowTwo5sAndGet10AfterMistake()
        {
            DiceGame dicegame = new DiceGame(new Random());
            dicegame.ThrowDices(5, 5);

            Assert.AreEqual($"You threw the dices and got 10! First dice got 5 and the second dice got 5 after 1 tries.", dicegame.Feedback);
            dicegame.ThrowDices(1, 6);

            Assert.AreEqual($"Well done you win, you got 7! You threw the dices and got 7! First dice got 1 and the second dice got 6 after 2 tries.", dicegame.Feedback);
        }
        [TestMethod]
        public void ThrowCorrectFirstTryWithDicesLandingOn4And3()
        {
            DiceGame dicegame = new DiceGame(new Random());
            dicegame.ThrowDices(4, 3);

            Assert.AreEqual($"Well done you win, you got 7! You threw the dices and got 7! First dice got 4 and the second dice got 3 after 1 tries.", dicegame.Feedback);
        }
        [TestMethod]
        public void ThrowALotWrong()
        {
            DiceGame dicegame = new DiceGame(new Random());

            dicegame.ThrowDices(4, 1);
            Assert.AreEqual($"You threw the dices and got 5! First dice got 4 and the second dice got 1 after 1 tries.", dicegame.Feedback);

            dicegame.ThrowDices(2, 2);
            Assert.AreEqual($"You threw the dices and got 4! First dice got 2 and the second dice got 2 after 2 tries.", dicegame.Feedback);

            dicegame.ThrowDices(1, 2);
            Assert.AreEqual($"You threw the dices and got 3! First dice got 1 and the second dice got 2 after 3 tries.", dicegame.Feedback);

            dicegame.ThrowDices(2, 4);
            Assert.AreEqual($"You threw the dices and got 6! First dice got 2 and the second dice got 4 after 4 tries.", dicegame.Feedback);

            dicegame.ThrowDices(1, 1);
            Assert.AreEqual($"You threw the dices and got 2! First dice got 1 and the second dice got 1 after 5 tries.", dicegame.Feedback);
        }
        [TestMethod]
        public void RunUntilDiceSeven()
        {
            DiceGame dicegame = new DiceGame(new Random());
            while (dicegame.YouAreAWinner == false)
            {
                dicegame.ThrowDices();
                Debug.WriteLine("Dicegame feedback: " + dicegame.Feedback);
            }
            Assert.IsTrue(dicegame.YouAreAWinner);
        }
    }
}
