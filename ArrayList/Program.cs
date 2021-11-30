using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayListe
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            // liste.Add("Ayşe");
            // liste.Add(2);
            // liste.Add(true);
            // liste.Add('a');

            // System.Console.WriteLine( liste[1]);
        
            // foreach (var item in liste)
            // {
            //     System.Console.WriteLine(item);
            // }

            System.Console.WriteLine("***** add range *******");
           // string[] renkler = {"kırmız","sarı","yeşil"};
            List<int> sayilar = new List<int>(){1,2,3,4,5,6};
           // liste.AddRange(renkler);
            liste.AddRange(sayilar);
            
             foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }

            //sort
            Console.WriteLine("*******sort******");
            liste.Sort();

             foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }
            Console.WriteLine("******binary search**");
            System.Console.WriteLine( liste.BinarySearch(9));

            //reverse
            System.Console.WriteLine("****reverse*****");
            liste.Reverse();
            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }
            //clear 
            liste.Clear();
             foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
