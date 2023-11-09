using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+ " added");
            //product.ProductName = "Camera";
            //product.UnitPrice = 0;
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " updated");
        }

        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public void Sum2(int num1, int num2)
        {
            Console.WriteLine(num1+num2);
        }

        //public void BiseyYap(int sayi) 
        //{
        //    sayi = 99;
        //    Console.WriteLine(sayi);
        //}
    }
}
