using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_09_13_consolApp
{
    public class PurchaseCalculation
    {
        public decimal Execute(int qty, decimal amount, bool withVat)
        {
        if (withVat)
            return qty * amount * 1.25M;
        else
            return qty * amount;
        }
    }
}
