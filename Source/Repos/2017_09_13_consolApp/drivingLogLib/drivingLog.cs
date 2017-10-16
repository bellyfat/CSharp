using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drivingLogLib
{
    public class drivingLog
    {

        List<Entry> entriesList = new List<Entry>();

        public void addEntry(DateTime date, decimal miles, string description)
        {
            entriesList.Add(
                new Entry
                {   Date = date,
                    Miles = miles,
                    Description = description
                });
        }

        public decimal MilesDriven(DateTime date)
        {
            return 
                entriesList.
                Where(e => e.Date.Year == date.Year && e.Date.Month == date.Month)
                .Sum(e => e.Miles);
        }
    }
}
