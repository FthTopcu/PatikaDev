using System;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Çalışan Sayısı : {0}", Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Ayşe", "Yılmaz", "IK");
            System.Console.WriteLine("Çalışan Sayısı : {0}", Calisan.CalisanSayisi);
            Calisan calisan2 = new Calisan("ders", "hyn", "IK");
            Calisan calisan3 = new Calisan("koş", "aslan", "IK");
            System.Console.WriteLine("Çalışan Sayısı : {0}", Calisan.CalisanSayisi);

            System.Console.WriteLine(Islemler.Topla(100,200));      
            System.Console.WriteLine(Islemler.Cikar(100,200));      

        }

    }
    class Calisan
    {
        private static int calisanSayisi;
        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;
        private string Soyisim;
        private string Departman;
        static Calisan()
        {
            calisanSayisi = 0;
        }
        public Calisan(string ısim, string soyisim, string departman)
        {
            Isim = ısim;
            Soyisim = soyisim;
            Departman = departman;
            calisanSayisi++;
        }
    }
    static class Islemler
    {
        public static long Topla(int Sayi1, int Sayi2)
        {
            return Sayi1 + Sayi2;
        }
        public static long Cikar(int Sayi1, int Sayi2)
        {
            return Sayi1 - Sayi2;
        }
    }
}
