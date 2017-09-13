using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_09_13_consolApp
{
    public class DateHandler
    {
        public int DaysBetweenDates(DateTime firstDate, DateTime secondDate)
        {
           return Convert.ToInt32((secondDate.Date - firstDate.Date).TotalDays);
        }
        public DateTime Add1000Days(DateTime theDate)
        {
            return theDate.AddDays(1000);
        }
    }
}
