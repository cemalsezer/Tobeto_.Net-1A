namespace ValueAndReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 30;
            num1 = num2;
            num2 = 65;
            Console.WriteLine(num1);//30

            int[] numA1 = new int[] { 10, 20, 30 };
            int[] numA2 = new int[] { 100, 200, 300 };
            numA1 = numA2;
            numA2[0] = 999;
            Console.WriteLine(numA1[0]);//999

            //Değer tipleri (value - primitive types):int, decimal, float, double, bool, char
            //Referans tipleri(reference):array, class, interface
        }
    }
}