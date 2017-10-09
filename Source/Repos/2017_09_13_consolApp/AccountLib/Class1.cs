using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountLib
{
    public class Class1
    {
        // Tillgångar toppnivå
        // Består utav underkonton

        public string Code;
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public bool IsSummary { get; set; }
        public List<AccountLib> Children { get; set; }
        
    }
}
