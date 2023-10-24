// DRY - DONT REPEAT YOURSELF 
/*
Add();
Add();
Add();

var result = Add2(20,30);
Console.WriteLine(result);
*/


// var result = Add2(20);
// var result = Add2(); 

// int number1 = 20; 
// int number1; 
// int number2 = 100;
// var result2 = Add3(ref number1,number2);
// Console.WriteLine(result2);
// Console.WriteLine(number1);


Console.WriteLine(Multiply(2, 4));
Console.WriteLine(Multiply(2, 4, 5));

Console.WriteLine(Add4(1, 2, 3, 4, 5, 6)); 

Console.ReadLine();
    }

    static void Add()
{
    Console.WriteLine("Added!!!");
}

static int Add2(int number1, int number2)
{
    var result = number1 + number2;
    return result;
}




static int Add2(int number1 = 20, int number20 = 30)
{
    var result = number1 + number2;
    return result;
}


static int Add3(ref int number1, int number2)
{
    number1 = 30;
    return number1 + number2;

}
// Method overloading

static int Multiply(int number1, int number2)
{
    return number1 * number2;
}
 
static int Multiply(int number1, int number2, int number3)
{
    return number1 * number2 * number3;
}

// Params 
static int Add4(params int[] numbers)
{
    return numbers.Sum();
}