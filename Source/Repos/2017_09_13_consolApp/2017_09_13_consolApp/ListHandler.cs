using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_09_13_consolApp
{
    public class ListHandler
    {
        public List<string> List = new List<string>();

        public void AddFiveStrings()
        {
            for (int x = 0; x < 5; x++)
            this.List.Add("geh " + x);
        }

        public void RemoveThirdString()
        {
            this.List.RemoveAt(2);
        }

        public void Sort()
        {
            List.Sort();
            throw new ArgumentOutOfRangeException();
        }
    }
}
