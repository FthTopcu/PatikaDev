using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayi giriniz.");
            int sayac=int.Parse(Console.ReadLine());
            for (int i = 0; i <= sayac; i++)
            {
                if(i%2==1){
                    Console.WriteLine(i);
                }
            }
            int tekToplam=0;
            int ciftToplam=0;
            for (int i = 0; i <= 1000; i++)
            {
                if(i%2==1)
                    tekToplam += i;
                else
                    ciftToplam += i;
            }
            Console.WriteLine("Tektoplam :" + tekToplam + "ciftToplam :" +ciftToplam);
        }
    }
}
