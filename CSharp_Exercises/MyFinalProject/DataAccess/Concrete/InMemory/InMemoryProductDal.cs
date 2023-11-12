using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
            new Product{Id=1, CategoryId=1, Name="Bardak", UnitPrice=15, UnitsInStock=15 },
            new Product{Id=2, CategoryId=1, Name="Kamera", UnitPrice=500, UnitsInStock=3 },
            new Product{Id=3, CategoryId=2, Name="Telefon", UnitPrice=1500, UnitsInStock=2 },
            new Product{Id=4, CategoryId=2, Name="Klavye", UnitPrice=150, UnitsInStock=65 },
            new Product{Id=5, CategoryId=2, Name="Fare", UnitPrice=85, UnitsInStock=1 }
            };
        }
        public List<Product> GetAll()
        {
            return _products;
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }
        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(item => item.Id == product.Id);
            _products.Remove(productToDelete);
        }
        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(item => item.Id == product.Id);
            productToUpdate.Name=product.Name;
            productToUpdate.UnitPrice=product.UnitPrice;
            productToUpdate.CategoryId=product.CategoryId;
            productToUpdate.UnitsInStock=product.UnitsInStock;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
          return  _products.Where(item=>item.CategoryId==categoryId).ToList();
        }
    }
}
