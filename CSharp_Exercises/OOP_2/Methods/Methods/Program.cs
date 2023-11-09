namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productName = "Apple";
            double price = 15;
            string desc = "Apple of Amasya";
            //string[] fruits = new string[]{};
            
            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 15;
            product1.Description = "Apple of Amasya";

            Product product2 = new Product();
            product2.Name = "Water Melon";
            product2.Price = 10;
            product2.Description = "WaterMelon of Diyarbakır";

            Product[] products = new Product[] { product1, product2 };

            foreach(Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("----------------");
            }
            Console.WriteLine("----*-*-*-*-*Methods*-*-*-*-*----");

            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            basketManager.Add(product2);

            Console.WriteLine("-----");
            basketManager.Add2("Apple", "Apple of Amasya", 15);
            basketManager.Add2("Apple", "Apple of Amasya", 15);

        }
    }
}