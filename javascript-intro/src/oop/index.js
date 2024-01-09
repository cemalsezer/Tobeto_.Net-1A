// class Customer{
//     constructor(id, customerNumber){
//     }
// }

// let customer = new Customer(1, "123456");
// console.log(customer.id)    //undefined 
// console.log(customer.name)   

class Customer{
    constructor(id, customerNumber){
        this.id = id
        this.customerNumber = customerNumber
    }
}
let customer = new Customer(1, "123456");
console.log(customer.id)               
console.log(customer.customerNumber)    

customer.name = "Murat Kurtboğan"
console.log(customer.name)

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