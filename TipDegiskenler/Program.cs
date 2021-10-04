using System;

namespace TipDegiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion
           byte a=5;
           sbyte b=30;
           short c=10;

           int d=a+b+c;
           Console.WriteLine("d: " + d);
           
           long h=d;
           Console.WriteLine("h: " + h);

           float f=h;
           Console.WriteLine("f :" +f);

           string e="fatih";
           char i='k';
           object g=e+i+d;
           Console.WriteLine("g :" +g);

           //explicit conversion

           int x=4;
           byte y= (byte)x;

           int z=100;
           byte t=(byte)z;

           float w=10.3f;
           byte v=(byte)w;

           //tostring methodu

           int xx=6;
           string yy=xx.ToString();
           string zz = 12.5f.ToString();
           Console.WriteLine(zz);
        }
    }
}
