using System;

namespace WhileForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            Console.WriteLine(" 1den başlayarak consoledan girilen sayıya kadar ortalama hesaplayan program için bir sayi giriniz");   
            int sayi =int.Parse(Console.ReadLine());
            int sayac =1;
            int toplam=0;
            while(sayac<=sayi)
            {
                toplam+=sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);
            // 'a' dan 'z'ye kadar harflerin yazımı
            char character='a';
            while (character<'z')
            {
                Console.Write(character);
                character++;
            }

            //foreach

            string[] arabalar={"BMW","Ford","Toyota","Nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
