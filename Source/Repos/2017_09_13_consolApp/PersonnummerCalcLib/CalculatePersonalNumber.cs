
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnummerCalcLib
{
    public class CalculatePersonalNumber
    {
        private int[] socialnumber;
        private readonly int[] formula = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
        public CalculatePersonalNumber(int[] socialnumber)
        {
            this.socialnumber = socialnumber;
        }

        public int getLastDigit()
        {
            int firstrowtotal = 0;
            int[] socialtimesresultTimes = new int[socialnumber.Count()];
            int[] socialtimesresultPlus = new int[socialnumber.Count()];
            
            // *
            for (int x = 0; x < socialnumber.Count(); x++)
            {
                Debug.WriteLine($"Social number: {this.socialnumber[x]} times {formula[x]} equals {this.socialnumber[x] * formula[x]}");
                socialtimesresultTimes[x] = this.socialnumber[x] * formula[x];
            }
            // +
            for (int x = 0; x < socialnumber.Count(); x++)
            {
                if (socialtimesresultTimes[x].ToString().Count() > 1)
                {
                    char[] chars = socialtimesresultTimes[x].ToString().ToCharArray();
                    int[] allDigitsOfNumber = Array.ConvertAll(chars, c => (int)Char.GetNumericValue(c));
                    socialtimesresultPlus[x] = allDigitsOfNumber.Sum();
                }
                else
                {
                    socialtimesresultPlus[x] = socialtimesresultTimes[x];
                }
            }
            
            Debug.WriteLine($"Social number results after *: {string.Join(",", socialtimesresultTimes)}");
            Debug.WriteLine($"Results of the row looks like this after +: {string.Join(", ", socialtimesresultPlus)}");
            Debug.WriteLine($"Total of each of these numbers is: {socialtimesresultPlus.Sum()}");

            double thesum = socialtimesresultPlus.Sum();
            double nextTenth = Math.Ceiling((double)thesum / 10) * 10;
            Debug.WriteLine($"Next ten: {nextTenth} and you have sum {thesum}.");
            return (int)(nextTenth - thesum);
        }
    }
}
