﻿using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();
            if (result.Success == true)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ProductName + "/" + item.CategoryName);
                }
            }
            else{
                Console.WriteLine(result.Message);
            }

        }
    }
}