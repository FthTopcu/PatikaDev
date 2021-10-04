using System;

namespace IfElseif
{
    class Program
    {
        static void Main(string[] args)
        {
            int time=DateTime.Now.Hour;
            
            if(time>=6 && time<11)
                Console.WriteLine("gunaydin");
            else  if(time<=18)
                Console.WriteLine("iyi gunler");
            else 
                Console.WriteLine("iyi geceler");

            string sonuc =time<=18 ? "iyi Gunler": "iyi geceler";
            sonuc = time >= 6  && time < 11 ? "Gunaydin" : time <= 18 ? "iyi Gunler" : "iyi Geceler";
            Console.WriteLine(sonuc);
        }
    }
}
