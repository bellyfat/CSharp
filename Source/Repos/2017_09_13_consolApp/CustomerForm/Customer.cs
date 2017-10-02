using System;

namespace CustomerForm
{
    public class Customer
    {
        public DateTime Birthday;
        public string Name;
        public string TelNr;
        public int Order;
        internal DateTime Timestamp = DateTime.Now;
                
    }
}