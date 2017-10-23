using SIEReadingLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIEReadingConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Filename: (TIP: USE MATTIAS0_SIE4 2015-09-01 - 2016-08-31.SE.txt)");
            string filename = Convert.ToString(Console.ReadLine());
            
            if(File.Exists(filename))
            { 
                SIEReading siereading = new SIEReading(filename, @"(#TRANS \d{4}\D{4})(.{0,100})");
                Console.WriteLine("Rows: " + siereading.MatchingRows);
                Console.WriteLine("Total value of all transactions: " + siereading.TotalSumFromPattern());
            }
            else
                Console.WriteLine("File does not exist");
        }
    }
}
