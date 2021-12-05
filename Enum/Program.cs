using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Gunler.Pazar);
            System.Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik = 25;
            if (sicaklik <= (int)HavaDurumu.Normal)
            {
                System.Console.WriteLine("Dışarıya çıkmak için havanın ısınmasını bekle.");
            }
            else if (sicaklik >= (int)HavaDurumu.Sicak)
                System.Console.WriteLine("sıcak bir gün");
            else if (sicaklik >= (int)HavaDurumu.Normal && sicaklik < (int)HavaDurumu.Sicak)
                System.Console.WriteLine("dışarı çıkalım");
        }
    }
    enum Gunler
    {
        Pazartesi,
        Sali,
        Çarşamba,
        Perşembe,
        Cuma = 23,
        Cumartesi,
        Pazar
    }
    enum HavaDurumu
    {
        Soguk = 4,
        Normal = 20,
        Sicak = 25,
        CokSicak = 35
    }
}
