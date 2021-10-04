using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("bir sayi giriniz");
                int sayi=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("sayi :" + sayi);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata : "+ ex.Message.ToString());
            }
          /*  finally
            {
                Console.Write("işlem tamamlandı.");
            }*/
           try
           {
               //int a=int.Parse(null);
                int a=int.Parse("test");
                int g=int.Parse("-2000000000000000");
           }
           catch(ArgumentNullException ex)
           {
               Console.WriteLine("bos deger girdiniz");
               Console.WriteLine(ex);
           }
           catch(FormatException ex)
           {
               Console.WriteLine("veri tipi uygun degil");
               Console.WriteLine(ex);
           }
           catch(OverflowException ex)
           {
               Console.WriteLine("cok kucuk ya da cok buyuk bir deger girdinz");
               Console.WriteLine(ex);
           }
           finally{
               Console.WriteLine("islem basariyla tamamlandi");
           }
        }
    }
}
