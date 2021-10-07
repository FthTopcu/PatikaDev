using System;

namespace Arrayler
{
    class Program
    {
        static void Main(string[] args)
        {
              //sort 
            int[] sayiDizisi={23,12,4,86,72,3,11,17};  
            Console.WriteLine("***Sirasiz dizi***");
            foreach (var sayi in sayiDizisi)
                Console.Write(sayi+",");
            Console.WriteLine("");

            Console.WriteLine("***Sirali Dizi***");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.Write(sayi+",");
            Console.WriteLine("");
            
            //clear
            Console.WriteLine("***Array Clear***"); 
            // sayidizisi elemanlarını kullanarak 2.indexten itibaren 2 elemanı sıfırlar
            Array.Clear(sayiDizisi,2,2);
            foreach (var sayi in sayiDizisi)
                Console.Write(sayi+",");
            Console.WriteLine("");

            //reverse
            Console.WriteLine("***Array Reverse***"); 
              Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.Write(sayi+",");
            Console.WriteLine("");

            //IndexOf
            Console.WriteLine("***Array IndexOf***"); 
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));
            
            //Resize
            Console.WriteLine("***Array Resize***"); 
            Array.Resize<int>(ref sayiDizisi , 9);
            sayiDizisi[8]=99;
            foreach (var sayi in sayiDizisi)
                Console.Write(sayi+",");
            Console.WriteLine("");
      }
    }
}
