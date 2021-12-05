using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar = 3;
            dikdortgen.UzunKenar = 4;

            System.Console.WriteLine("Class Alan Hesabı : " + dikdortgen.AlanHesapla());

            Dikdortgen_Struct dikdortgen_Struct = new Dikdortgen_Struct(3,4);
            System.Console.WriteLine("Class Alan Hesabı : " + dikdortgen_Struct.AlanHesapla());

        }
    }
    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;
        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
    struct Dikdortgen_Struct
    {
     
        public int KisaKenar;
        public int UzunKenar;
        public Dikdortgen_Struct(int kisaKenar,int uzunKenar)
        {
            KisaKenar = 3;
            UzunKenar = 4;
        }
        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
}
