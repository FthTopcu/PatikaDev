using System;

namespace PatikaDevDegiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("11");
            byte b = 5; //1 byte
            sbyte c = 5; //1 byte

            short s = 5;    //2 byte
            ushort us = 5; //2 byte
            
            Int16  i16 = 5; //2 byte
            int i = 5;             //4 byte
            Int32 int32 = 5; //4 byte
            Int64 i64 =5;    //8byte
           
           uint ui =2;   //4byte
           long l=4;     //8byte
           ulong ul=4;    //8byte


           //reel sayılar
           float f =5;  //4byte
           double d=5; //8byte
           decimal de=5;  //16byte


           char ch ='2';    //2byte
           string str="fatih"; //sınırsız

           bool b1 = true;
           bool b2= false;

           DateTime dt = DateTime.Now;
           Console.WriteLine(dt);

           object o1 ="x";
           object o2='y';
           object o3=4;
           object o4=4.3;

        //string ifadeler

        string str1=string.Empty;
        str1="FatihTopcu";
        string ad="fatih";
        string soyad="topcu";
        string tamisim=ad +" "+soyad;

        // integer tanımlama şekilleri
        int integer1=5;
        int integer2=3;
        int integer3=integer1*integer2;

        //boolean
        bool bool1 =10<2;

        //degisken dönüşümleri
        string str20="20";
        int int20=20;
        string yeniDeger=str20+int20.ToString();
        Console.WriteLine(yeniDeger);
        
        int int21=int20+Convert.ToInt32(str20);
        Console.WriteLine(int21);

        int int22=int20+ int.Parse(str20); 

        //datetime

        string datetime=DateTime.Now.ToString("dd.mm.yyyy");
        Console.WriteLine(datetime);   

        string datetime2=DateTime.Now.ToString("dd/mm/yyyy");
        Console.WriteLine(datetime2); 

        string hour=DateTime.Now.ToString("HH:mm");
        Console.WriteLine(hour); 



            Console.WriteLine("Hello World!");
        }
    }
}
