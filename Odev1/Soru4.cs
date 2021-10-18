using System;
using System.Collections.Generic;
using System.Text;

namespace Soru4
{

    //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
    //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle giriniz .");
            string cumle = Console.ReadLine();
            string list = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ"
                      + "abcçdefgğhıijklmnoöprsştuüvyz";
            string[] words = cumle.Split(' ');
            Console.WriteLine("Kelime Sayısı: " + words.Length);

            int count = 0;
            for (int i = 0; i < cumle.Length; i++)
            {
                //karakter katarkter kontrol ediyoruz.
                if (list.Contains(cumle[i]))
                {
                    count++;
                }
            }
            Console.WriteLine("toplam {0} tane  harf vardır.", count);
            //Console.ReadLine();
        }
    }
}