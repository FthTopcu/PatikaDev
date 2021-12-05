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
            Calisan calisan1=new Calisan("ayşe","kara",15843,"İK");
            calisan1.CalisanBilgileri();

            Calisan calisan2=new Calisan();
            calisan2.Ad="aye";
            calisan2.Soyad="ra";
            calisan2.No=158;
            calisan2.Departman="K";
            calisan2.CalisanBilgileri();

            Calisan calisan3=new Calisan("ayşe","kara");
            calisan3.CalisanBilgileri();

            
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public Calisan(string ad , string soyad , int no , string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman; 
        }
        public Calisan(string ad , string soyad )
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }
        public Calisan(){}
        public void CalisanBilgileri()
        {
            System.Console.WriteLine(Ad);
            System.Console.WriteLine(Soyad);
            System.Console.WriteLine( No);
            System.Console.WriteLine( Departman);
        }
    }
}
