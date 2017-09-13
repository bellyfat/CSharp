using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_09_13_consolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ListHandler listHand = new ListHandler();
            const int AddFiveNumber = 5;
            for (int x = 0; x < AddFiveNumber; x++)
            {
                listHand.List.Add(Console.ReadLine());
            }
            
        }
    }
}
