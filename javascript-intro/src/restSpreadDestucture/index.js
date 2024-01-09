//rest
//params

let showProducts = function(id,...products){
    console.log(id)
    console.log(products[0])
} 
// console.log(typeof showProducts)
// showProducts(10,"Elma","Armut","Karpuz")

console.log(Math.max(1, 2, 13, 5, 35, 65, 9))


//spread - ayrıştırmak
let points = [1, 2, 13, 5, 35, 65, 9]
console.log(...points) //ayırır
console.log(Math.max(...points)) // 65
console.log(..."ABC","D", ..."EFG", ..."H") //A B C D E F G H 

//Destructuring - PARÇALAMAK

let populations = [10000,20000,30000,[40000,50000]]
let [small,medium,high,[veryHigh,maximum]]=populations 
console.log(small)
console.log(medium)
console.log(high)
console.log(veryHigh)
console.log(maximum)

function someFunction([small1],number){
    console.log(small1)
}
someFunction(populations)

let category = {id:1, name:"İçecek"}
console.log(category.id)
console.log(category["name"])

let{id,name}=category
console.log(id)
console.log(name)