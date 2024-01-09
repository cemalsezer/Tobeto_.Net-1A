//!!!! JavaScripte Aslında herşey functiondur, classlar bile
// class Customer{
//     constructor(id, customerNumber){
//     }
// }

// let customer = new Customer(1, "123456");
// console.log(customer.id)    //undefined olur
// console.log(customer.customerNumber)    //undefined olur-Aslında dikkat et sadece constructure a parametre geçtik
//Ancak alanları tanımlarsak (içinde prototyping) this ile
//Artık id ve customerNumber a erişilebilir
class Customer{
    constructor(id, customerNumber){
        this.id = id
        this.customerNumber = customerNumber
    }
}
let customer = new Customer(1, "123456");
console.log(customer.id)                //Artık okuyabiliriz.
console.log(customer.customerNumber)    //Artık okuyabiliriz.

//Prototyping >>> Bir classa SONRAdan yeni properties, attribute, fonk vb ekleme...
// >> Instance de prototyping 
customer.name = "Murat Kurtboğan"
console.log(customer.name)

// >> Class da prototyping 
Customer.yenibisey = "Birşey"
console.log(Customer.yenibisey)

//Inheritance
class IndividualCustomer extends Customer{
    constructor(firstname, id, customerNumber){
        super(id, customerNumber)
        this.firstname = firstname
    }
}

class CorporateCustomer extends Customer{
    constructor(companyname, id, customerNumber){
        super(id, customerNumber)
        this.companyname = companyname
    }
}