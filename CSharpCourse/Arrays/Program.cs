
// string[] students = new string[3];
//students[0] = "Engin";
//students[1] = "Derin";
//students[2] = "Salih";
// string[] students = new [] { "Engin", "Derin", "Salih" }; 

string[] students = { "Engin", "Derin", "Salih" };

foreach (var student in students)
{
    Console.WriteLine(student);
}

Console.WriteLine();
Console.ReadLine();



string[,] regions = new string[5, 3]
{
            {"İstanbul", "Balıkesir", "İzmit"},
            {"Ankara", "Konya", "Kırıkkale"},
            {"Antalya", "Adana", "Mersin"},
            {"Rize", "Trabzon ", "Samsun"},
            {"İzmir", "Manisa", "Muğla"}
};

for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i, j]);
    }
    Console.WriteLine("*****************");
}