


if (IsPrimeNumber(6))
{
    Console.WriteLine("This is a Prime Number ");
}
else
{
    Console.WriteLine("This is not a Prime Number ");
}


Console.ReadLine();
    

    private static bool IsPrimeNumber(int number)
{
    bool result = true;

    for (int i = 2; i < number - 1; i++)
    {
        if (number % i == 0)
        {
            result = false;
            i = number;
        }
    }
    return result;
}
private static void ForEachLoop()
{

    string[] students = new string[3] { "Engin", "Derin", "Salih" };

    foreach (string student in students)
    {
        Console.WriteLine(student);
    }

}
private static void WhileLoop()
{
    int number = 100;

    while (number >= 0)
    {
        Console.WriteLine("Now number is {0}", number);
        number--; 
    }
}

private static void DoWhileLoop()
{
    int number = 10;

    do
    {
        Console.WriteLine(number);
        number--;

    } while (number >= 0);
}
private static void ForLoop()
{

    for (int i = 1; i <= 100; i++) 
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Finished");

   

    for (int i = 1; i <= 100; i += 2)  
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Finished");



    for (int i = 2; i <= 100; i += 2)  
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Finished");



    for (int i = 100; i >= 0; i--) 
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Finished");