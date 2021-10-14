using System;

namespace metotOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi ="999";

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if(sonuc)
            {
                Console.WriteLine("Basarili");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("basarisiz");
            }
            
            metotlar instance =new metotlar();
            instance.Topla(2,3,out int toplamsonucu);
            Console.WriteLine(toplamsonucu);

            //metot Asiri Yukleme - Overloading
            int ifade = 999;
            instance.EkranaYazdir(ifade.ToString());
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("fatih","topcu");

            //metot imzasi
            //metotadi + parametre sayisi + parametre
        }
    }
    class metotlar
    {
        public void Topla(int a, int b , out int toplam)
        {
            toplam = a+b;
        }
        
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

         public void EkranaYazdir(string veri1 ,string veri2)
        {
            Console.WriteLine(veri1+veri2);
        }
    }
}
