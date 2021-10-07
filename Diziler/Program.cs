using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi tanımlama
            string[] renkler =new string[5];

            string[] hayvanlar={"Kedi","Kopek","Kus","Maymun"};

            int[] dizi;
            dizi=new int[5];
            //dizilere deger atama 
            renkler[0]="Mavi";

            dizi[3]=10;
            
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //dongulerle dizi kullanimi
            //n tane sayinin ort hesaplama
            Console.Write("dizinin eleman sayisini giriniz : ");
            int diziUzunlugu=int.Parse(Console.ReadLine());
            int[] sayiDizisi=new int[diziUzunlugu];
            
            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("lutfen {0} . sayisi giriniz :",i+1);
                sayiDizisi[i]=int.Parse(Console.ReadLine());
            }
            int toplam=0;
            foreach (var sayi in sayiDizisi)
            {
                toplam+=sayi;
            }
            Console.WriteLine("ortalama :" +toplam/diziUzunlugu);
        }
    }
}
