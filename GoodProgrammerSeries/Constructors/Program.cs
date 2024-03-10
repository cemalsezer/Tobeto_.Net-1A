namespace Constructors;

internal abstract class Program
{
    public static void Main(string[] args)
    {
        Customer customer1 = new Customer { Id = 1, FirstName = "Cemal", LastName = "Sezer", City = "İzmir" };
        Customer customer2 = new Customer(2, "Kemal", "Atatürk", "Selanik"); 
        Customer customer3 = new Customer();
        customer3.Id = 3;
        customer3.FirstName = "Julius";
        customer3.LastName = "Caesar";
        customer3.City = "Rome";

        Console.WriteLine(customer2.FirstName);
    }
}

class Customer
{

    public Customer(int id, string firstName, string lastName, string city) // with arguments
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        City = city;
    }

    public Customer() //default constructor
    {

    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}