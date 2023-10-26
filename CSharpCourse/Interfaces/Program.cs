interface IPerson
{
    string Name { get; set; }
    int Id { get; set; }
}

class Customer : IPerson
{
    public string Name { get; set; }
    public int Id { get; set; }
}

class Student:IPerson
{
    public string Name { get; set; }
    public int Id { get; set; }
}