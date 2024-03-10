namespace ReferenceTypes;
internal abstract class Program
{
    public static void Main(string[] args)
    {
        /*
        
        // int, decimal, float, enum, boolean are values types
        int number1 = 10;
        int number2 = 20;

        number1 = number2;
        number2 = 100;
        
        Console.WriteLine("number 1 : "+ number1); // 20
        
        // arrays, class, interface... reference types

        int[] numbers1 = new int[] { 1, 2, 3 };
        int[] numbers2 = new int[] { 10, 20, 30 };

        numbers1 = numbers2;
        numbers2[0] = 1000;

        Console.WriteLine("numbers1[0] is equal " + numbers1[0]); 
        
        foreach (int number in numbers1)
        {
            Console.WriteLine(number); // 1000, 20, 30
        }
        
        */

        Person person = new Person();
        Person person1 = new Person();
        Person person2 = new Person();

        Customer customer = new Customer();
        Employee employee = new Employee();
       
        employee.FirstName = "Cemal";


        Person person3 = customer;
        customer.FirstName = "Cemal";
        customer.CreditCardNumber = "12345678910";
        //Console.WriteLine(person3.FirstName);
        Console.WriteLine(((Customer)person3).CreditCardNumber);


        person1.FirstName = "Cemal";
        person2 = person1;
        person1.FirstName = "MKA";

        //Console.WriteLine(person2.FirstName);

        PersonManager personManager = new PersonManager();
        personManager.Add(customer);




    }
}

class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer : Person
{
    public string CreditCardNumber { get; set; }
}

class Employee : Person
{
    public int EmployeeNumber { get; set; }
}

class PersonManager
{
    public void Add(Person person)
    {
        Console.WriteLine(person.FirstName);
    }
}