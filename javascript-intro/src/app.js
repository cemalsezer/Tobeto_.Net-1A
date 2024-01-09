let sayi1=30;
sayi1 = "Cemal Sezer"
let student = {id:1, name:"Cemal"}; 
console.log(student);

function save(puan=50, ogrenci){
    console.log(ogrenci.name+":"+puan)
}
save(undefined,student);

let students = ["Timur", "Attila", "Aleksandros"]
console.log(students)
let students2 = [student,{id:2,name:"Timur"},"İzmir", {city:"İstanbul"}]
console.log(students2)
