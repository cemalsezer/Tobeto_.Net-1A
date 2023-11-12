using Business.Concrete;
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
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var item in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}