using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2017_09_13_consolApp;

namespace StorytellerTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TellStoryToYoung()
        {
            // vad vi testar
            Storyteller storyteller = new Storyteller();
            string nameofchild = "Sara";
            bool willbescary = false;
            int ageOfChild = 5;

            string story = storyteller.TellStory(nameofchild, ageOfChild, willbescary);
            string princessver = String.Format("Lyssna nu {0}. Det var en gång en prinsessa", nameofchild);
            string maturever = String.Format("Hallå {0}! En gång fanns en kille", nameofchild);
            string scaryContinued = "som egentligen var en varul";
            string NotscaryContinued = "som tyckte om att dansa";
            
            Assert.AreEqual(princessver + NotscaryContinued, story);
        }
        public void TellStoryToOldChildScary()
        {
            Storyteller storyteller = new Storyteller();
            string nameofchild = "Peter";
            bool willbescary = true;
            int ageOfChild = 9;

            string story = storyteller.TellStory(nameofchild, ageOfChild, willbescary);
            string princessver = String.Format("Lyssna nu {0}. Det var en gång en prinsessa", nameofchild);
            string maturever = String.Format("Hallå {0}! En gång fanns en kille", nameofchild);
            string scaryContinued = "som egentligen var en varul";
            Assert.AreEqual(maturever + scaryContinued, story);
        }
        [TestMethod]
        public void TellStoryYoungAndScared()
        {
            Storyteller storyteller = new Storyteller();
         
            string story = storyteller.TellStory("Peter", 3, true);
            string ChildrenShouldntBeScared = "Unga barn ska inte bli skrämda.";
            Assert.AreEqual(ChildrenShouldntBeScared, story);
        }
        [TestMethod]
        public void TellStoryToYoungAndNotScared()
        {
            Storyteller storyteller = new Storyteller();
            string nameofchild = "Peter";
            bool willbescary = false;
            int ageOfChild = 3;
            string story = storyteller.TellStory(nameofchild, ageOfChild, willbescary);
            string princessver = String.Format("Lyssna nu {0}. Det var en gång en prinsessa", nameofchild);
            string maturever = String.Format("Hallå {0}! En gång fanns en kille", nameofchild);
            string NotscaryContinued = "som tyckte om att dansa";
            
            Assert.AreEqual(princessver + NotscaryContinued, story);
        }
    }
}
