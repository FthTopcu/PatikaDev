using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            // class SinifAdi
            // {
            //     [Erişim Belirleyici][Veri Tipi] ÖzellikAdı;
            //     [Erişim Belirleyici][Geri Dönüş Değerinin Tipi] MetotAdi([Parametreler])
            //     {
            //         //Metot Gövdesi
            //     }
            // }
            //Erişim Belirleyiciler
            //public 
            //private
            //ınternal
            //protected
            Calisan calisan1=new Calisan();
            calisan1.Ad="ayşe";
            calisan1.Soyad="kara";
            calisan1.No=15843;
            calisan1.Departman="İK";
            calisan1.CalisanBilgileri();

            Calisan calisan2=new Calisan();
            calisan2.Ad="aye";
            calisan2.Soyad="ra";
            calisan2.No=158;
            calisan2.Departman="K";
            calisan2.CalisanBilgileri();


            
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public void CalisanBilgileri()
        {
            System.Console.WriteLine(Ad);
            System.Console.WriteLine(Soyad);
            System.Console.WriteLine( No);
            System.Console.WriteLine( Departman);
        }
    }
}
