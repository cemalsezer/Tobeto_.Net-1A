namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Table";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 10;

            Product product2 = new Product()
            { Id = 2, CategoryId = 2, ProductName ="Pencil", UnitPrice=300, UnitsInStock=2 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            int x = productManager.Sum(3, 5);
            Console.WriteLine(x*=5);

            //int sayi = 100;
            //productManager.BiseyYap(3);
            //Console.WriteLine(sayi); 
        }
    }
}