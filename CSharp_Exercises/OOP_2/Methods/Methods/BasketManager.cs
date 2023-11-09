using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class BasketManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Added to basket: " + product.Name);
        }

        public void Add2(string productName, string desc, double price)
        {
            Console.WriteLine("Added to basket: " + productName);
        }
    }
}
