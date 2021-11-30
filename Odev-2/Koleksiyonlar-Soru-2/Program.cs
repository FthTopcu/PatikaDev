using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
            // her iki grubun kendi içerisinde ortalamalarını alan 
            // ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
            int[] dizi = new int[20];
            int sayi;
            double buyukOrt = 0;
            double kucukOrt = 0;
            for (int i = 0; i < 20; i++)
            {
                sayi = Convert.ToInt32(Console.ReadLine());
                dizi[i]=sayi;
            }
            Array.Sort(dizi);
            for (int i = 0; i < 3; i++)
            {
                kucukOrt +=dizi[i];
            }
            for (int i = dizi.Length-1; i >= dizi.Length -4 ; i--)
            {
                buyukOrt += dizi[i];
            }
            foreach (var item in dizi)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine($"Buyuk ortalama = {buyukOrt} - Kucuk ortalama = {kucukOrt} - Ortalamaların toplamları = {buyukOrt+kucukOrt}");
        }
    }
}
