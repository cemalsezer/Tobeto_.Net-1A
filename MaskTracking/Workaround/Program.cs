namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();
            Vatandas vatandas1 = new Vatandas();

            SelamVer("Cemal");
            SelamVer("Ali");
            SelamVer("Mehmet");

            int sonuc = Topla(5, 5);

            //Diziler Arrays
            string ogrenci1 = "Cemal";
            string ogrenci2 = "Ali";
            string ogrenci3 = "Mehmet";

            Console.WriteLine(ogrenci1);
            Console.WriteLine(ogrenci2);
            Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Cemal";
            ogrenciler[1] = "Cemal";
            ogrenciler[2] = "Cemal";


            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new [] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new [] { "Bursa", "LA", "New York" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);
        }

        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba" + isim);
        }

        //fonksiyonlarda default parametler en sondan başlayarak yazılmalı
        static int Topla(int sayi1 = 5, int sayi2 = 6)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam" + sonuc);
            return sonuc;
        }

        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000;
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Cemal";
            string soyad = "Sezer";
            int dogumYili = 1998;
            long tcNo = 12345678910;

            Console.WriteLine(tutar * 1.18);
        }
    }
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogummYili { get; set; }
        public long TcNo { get; set; }

    }
}