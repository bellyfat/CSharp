using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_09_13_consolApp
{
    public class Storyteller
    {
        public string myword = "Hello World";
        public string TellStory(string nameOfChild, int ageOfChild, bool willBeScary)
        {
            string story = "";
            string princessver = String.Format("Lyssna nu {0}. Det var en gång en prinsessa", nameOfChild);
            string guysver = String.Format("Hallå {0}! En gång fanns en kille", nameOfChild);
            string scaryContinued = "som egentligen var en varul";
            string NotscaryContinued = "som tyckte om att dansa";
            
            if (ageOfChild < 7)
            {
                story =  princessver;
            }
            else
            {
                story = guysver;
            }

            if (willBeScary == true)
            {
                story += scaryContinued;
            }
            else if (willBeScary == false)
            {
                story += NotscaryContinued;
            }


            if (willBeScary == true && ageOfChild < 5)
            {
                story = "Unga barn ska inte bli skrämda.";
            }
            return story;
        }
    }
}
