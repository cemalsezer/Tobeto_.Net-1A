Person[] persons = new Person[3]
{
    new Customer
    {
        FirstName = "Cemal"
    }, 
    new Customer
    {
        FirstName= "Sezer"
    }
    , new Customer
    {
        FirstName="MKA"
    }
};
foreach (var person in persons)
{
    Console.WriteLine(person.FirstName);
}


class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }

    public string LastName { get; set; }
}

class Customer : Person
{
    public string City { get; set; }

}

class Studentd : Person
{
    public string Departent { get; set; }

}