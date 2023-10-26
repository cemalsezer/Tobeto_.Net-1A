using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace Classes;

public class Customer
{

    public int Id { get; set; }
    /*
    private string _firstName;
    public string FirstName
    {
        get { return "Mrs. " + _firstName; }
        set { _firstName = value; }

    }*/
    public string FirstName { get; set; } // Auto-property
    public string LastName { get; set; }
    public string City { get; set; }
}