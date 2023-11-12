using Business.Concretes;
using Entities.Concretes;
using System.ComponentModel;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Category category1 = new Category();
            category1.Id = 1;
            category1.Name = "Test";

            CategoryManager categoryManager = new CategoryManager();
            categoryManager.Add(category1);
        }
    }
}