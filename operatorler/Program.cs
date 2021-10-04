using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // atama ve işlemli atama
            int x =  3;
            int y = 3;
            y = y+2;
            y+=2;
            y/=1;
            x *=2;

            //Mantıksal Operatörler (||, &&, !)

            bool isSuccess=true;
            bool isComplated=false;

            if(isSuccess&&isComplated)
                Console.WriteLine("Perfect");
            if(isSuccess  || isComplated)
                Console.WriteLine("Great");
            if(isSuccess&&!Complated)
                Console.WriteLine("Fine");

            //İlişkisel operatörler
            //<,>,<=,>=,==,!=
            int a=3;
            int b=4;
            bool sonuc=a<b;
            Console.WriteLine(sonuc);
            sonuc=a>b;            
            Console.WriteLine(sonuc);            
            sonuc=a>=b;
            Console.WriteLine(sonuc);       
            sonuc=a<=b;
            Console.WriteLine(sonuc);       
            sonuc=a==b;
            Console.WriteLine(sonuc);            
            sonuc=a!=b;
            Console.WriteLine(sonuc);     
            //Aritmatik operatörler /,*,+,-

            int sayi1=10;
            int sayi2=5;
            int sonuc1=sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1+sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1++;
            Console.WriteLine(sonuc1);

             int sonuc2=20%3;
             Console.WriteLine(sonuc2);
            
            


        }
    }
}
