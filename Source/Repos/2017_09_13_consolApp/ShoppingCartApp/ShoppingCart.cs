using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    public class ShoppingCart
    {
        private List<Product> Products = new List<Product>();
        public Customer Customer { get; set; }
        public int Total
        {
            get
            {
                return Products.Sum(enProduct => enProduct.Price);
            }
        }
        public OrderConfirmation OrderConfirm { get; set; }

        public void AddProduct(Product produkt)
        {
            this.Products.Add(produkt);
        }

        public void Order()
        {
            this.OrderConfirm = new OrderConfirmation
            {
                Message = String.Format("{0} har beställt varor för {1} SEK", Customer.Name, Total)
            };
        }
    }
}
