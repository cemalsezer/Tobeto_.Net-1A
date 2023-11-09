namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "E", "M", "K", "H" };
            //Console.WriteLine(isimler[0]);

            //isimler = new string[5];
            //isimler[4] = "i";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string>() {"E", "M", "K", "H" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("i");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}