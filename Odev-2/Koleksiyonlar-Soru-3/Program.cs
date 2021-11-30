using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan 
            //dizinin elemanlarını sıralayan programı yazınız.
            // a, e, ı, i, o, ö, u, ü
            ArrayList sesliHarfler = new ArrayList(){'a','e','ı','i','o','ö','u','ü'};
            ArrayList girilenSesliHarfler = new ArrayList() ;
            string girilen = Console.ReadLine();
            for (int i = 0; i < girilen.Length; i++)
            {
                if(sesliHarfler.Contains(girilen[i])){
                    girilenSesliHarfler.Add(girilen[i]);
                }   
            }
            girilenSesliHarfler.Sort();
            foreach (var item in girilenSesliHarfler)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
