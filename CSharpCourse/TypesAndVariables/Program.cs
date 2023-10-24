

// Console.WriteLine("Hello World!");
// Value Types
//int data type
int number1 = 10;
int number2 = 2147483647; 
//tam sayıları tutar

Console.WriteLine("number1 is {0}", number1);
Console.WriteLine("number2 is {0}", number2);


//Long data type
long number3 = 2147483648;
Console.WriteLine("number3 is {0}", number3);
// long veri tipi 64 bitlik yer tutar. 


//Short data type
short number4 = 32767;
Console.WriteLine("number4 is {0}", number4);
// short veri tipi 16 bitlik yer tutar


//Byte data type 
byte number5 = 255;
Console.WriteLine("number5 is {0}", number5);
//min 0 max 255 sayı tutabilir.


// Bool data type 
bool condition = false; 
Console.WriteLine(condition);
// bool mantıksal bir veri tipidir. Tuttuğu değer true ya da false'tur. 


//Char data type 
char character = 'A';
Console.WriteLine(character);
// Klavyedeki tüm karakterleri tutabiliriz.


//String data type 
string city = "Ankara";
Console.WriteLine(city);
// Bir çeşit metin dizi setidir.

//Double data type
double number6= 10.4;
Console.WriteLine("number6 is {0}", number6);
// Ondalıklı sayıları tutmak için kullanılıyor.


//Decimal data type
decimal number7 = 10.4m;
Console.WriteLine("number7 is {0}", number7);
// int yerine long kullandığımız durumlardaki aynı ihtiyacı karşılar. Bir double için long decimaldır.
// sayısal, ondalıklı, daha hassas veriler için kullanılır. 


// Enum data type

//Console.WriteLine(Days.Friday);
//Console.WriteLine((int)Days.Friday);
//enum Days
//{
//    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
//}


// var data type
var number8 = 10;
Console.WriteLine("number8 is {0}", number8);
//ilk başta hangi veri verilirse onu tutmaya devam eder

Console.ReadKey();



