using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    public class Customer
    {
        public string firstname;
        public string lastname;

        public string Name
        {
            get
            {
                return firstname + " " +  lastname;
            }
        }
        public Customer(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }
    }
}
