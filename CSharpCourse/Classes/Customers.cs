using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace Classes;

 class Customer
{
    //property tanımlamak
    public int Id { get; set; }
    public string FirstName { get; set; } 
    /*
        public string Firstname 
            {
                get {return "Mr." + _firstName;}
                set {_firstName=value;}
            }
     */
    public string LastName { get; set; }
    public string City { get; set; }
    
}