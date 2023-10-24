CustomerManager customerManager = new CustomerManager(); 


customerManager.Add();
customerManager.Update();


ProductManager productManager = new ProductManager(); 
productManager.Add();
productManager.Update();

Customer customer = new Customer();
customer.City = "Ankara";
customer.Id = 1;
customer.FirstName = "Cemal";
customer.LastName = "Sezer";


Customer customer2 = new Customer
{
    Id = 2,
    City = "İzmir",
    FirstName = "Derin",
    LastName = "Demiroğ"
};


Console.WriteLine(customer2.FirstName);


Console.ReadLine();




class CustomerManager
{

    public void Add()
    {
        Console.WriteLine("Customer Added!");
    }

    public void Update()
    {
        Console.WriteLine("Customer Updated!");
    }
}

class ProductManager

{
    public void Add()
    {
        Console.WriteLine("Product Added!");
    }

    public void Update()
    {
        Console.WriteLine("Product Updated!");
    }