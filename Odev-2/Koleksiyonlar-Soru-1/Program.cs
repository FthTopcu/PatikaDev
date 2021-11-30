using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
            // Negatif ve numeric olmayan girişleri engelleyin.
            // Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            // Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
            ArrayList asal = new ArrayList();
            ArrayList asalDegil = new ArrayList();
             
             for (int i = 1; i < 21; i+=0)
             {
                 System.Console.WriteLine(i+". sayi ");
                string girilen = Console.ReadLine(); //Gelen veri bu değişkenin değerini alır.
                
                int sayi ;
                bool SayiMi = Int32.TryParse(girilen, out sayi);
                
                // System.Console.WriteLine(sayi + " " + SayiMi);
                if (!SayiMi)
                {
                    System.Console.WriteLine($"Geçersiz bir sayı girdiniz: {girilen}");
                    
                }
                else
                {
                    if( sayi > 0)
                    {
                        int kontrol = 0;
                        if(sayi==1 || sayi == 0)
                        {
                            asalDegil.Add(sayi);
                        }
                        else
                        {
                            for (int k = 2; k < sayi/2; k++)
                            {
                                if (sayi % k == 0) //Kalansız bölünüyormu?
                                {
                                    kontrol++;
                                   break; //Diğer sayılara bakmaya gerek duymuyoruz.
                                }
                            }
                            if (kontrol != 0)
                            {
                                
                                asalDegil.Add(sayi);
                            }
                            else
                            {
                               asal.Add(sayi);
                            }
                        }
                        
                    }
                    else{
                        System.Console.WriteLine("0 dan büyük sayı giriniz.");
                        i-=1;
                    }
                   i++;
                }
             }
            
            asal.Sort();
            asalDegil.Sort();
            asal.Reverse();
            asalDegil.Reverse();
            int asalSum = 0;
            int asalOlmayanSum = 0;
            System.Console.WriteLine("****asal sayılar****");
            foreach (int item in asal)
            {
                System.Console.WriteLine(item);
                asalSum = asalSum + item;
            }
            System.Console.WriteLine("Asal dizisinin eleman sayısı :" +asal.Count +" ve ortalaması : " + (asalSum/asal.Count));
            System.Console.WriteLine("****asal olmayanlar****");
            foreach (int item in asalDegil)
            {
                System.Console.WriteLine(item);
                asalOlmayanSum = asalOlmayanSum + item;
            }
            
            System.Console.WriteLine("Asal dizisinin eleman sayısı :" +asalDegil.Count +" ve ortalaması : " +(asalOlmayanSum/asal.Count));
        }
    }
}
