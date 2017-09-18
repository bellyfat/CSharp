using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    public class Product
    {
        private string Name;

        public Product(string name)
        {
            this.Name = name;
        }

        public int Price { get; set; }
    }
}
