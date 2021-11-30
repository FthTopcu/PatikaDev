using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary<int,string> kullanıcılar = new Dictionary<int, string>();

           kullanıcılar.Add(10,"ayşe yılmaz");
           kullanıcılar.Add(12,"ahmet yılmaz");
           kullanıcılar.Add(14,"arda turan");
           kullanıcılar.Add(16,"burak yılmaz");

            //dizinin elmeanlarına erişim
            System.Console.WriteLine("******elemanlara erişim*****");
            System.Console.WriteLine(kullanıcılar[12]);
            foreach (var item in kullanıcılar)
            {
                System.Console.WriteLine(item);
            }
            //count
            System.Console.WriteLine("******eleman sayısı*****");
            System.Console.WriteLine(kullanıcılar.Count);
            //contains
            System.Console.WriteLine("******Contains*****");
            System.Console.WriteLine(kullanıcılar.ContainsKey(12));
            System.Console.WriteLine(kullanıcılar.ContainsValue("fatih topcu"));
            //remove 
            System.Console.WriteLine("***remove***");
            kullanıcılar.Remove(12);
            foreach (var item in kullanıcılar)
            {
                System.Console.WriteLine(item);
            }
            //keys
            System.Console.WriteLine("***keys***");
            foreach (var item in kullanıcılar.Keys)
            {
                System.Console.WriteLine(item);
            }
            //Values
            System.Console.WriteLine("***Values***");
            foreach (var item in kullanıcılar.Values)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}
