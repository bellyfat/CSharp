using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drivingLogLib
{
    public class Entry
    {
        public DateTime Date { get; set; }
        public decimal Miles { get; set; }
        public string Description
        {
            get; set;
        }
    }
}
