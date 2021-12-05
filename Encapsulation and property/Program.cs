using System;

namespace Encapsulation_and_property
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "fatih";
            ogrenci.Soyisim = "Topcu";
            ogrenci.OgrenciNo = 1231;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci2 = new Ogrenci("Fatih", "Topcu", 52, 1);
            ogrenci2.SinifDusur();
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriniGetir();
        }
    }
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;
        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }

        public string Soyisim
        {
            get { return soyisim; }
            set { soyisim = value; }
        }
        public int OgrenciNo
        {
            get { return ogrenciNo; }
            set { ogrenciNo = value; }
        }

        public int Sinif
        {
            get => sinif;
            set
            {
                if (value < 1)
                {
                    System.Console.WriteLine("Sınıf en fazla 1 olabilr");
                    sinif = !;
                }
                else
                {
                    Sinif = value;
                }
            }
        }

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }
        public Ogrenci() { }

        public void OgrenciBilgileriniGetir()
        {
            System.Console.WriteLine("*****ogrenci Bilgileri");
            System.Console.WriteLine("Ogrenci Adı            : {0}", this.Isim);
            System.Console.WriteLine("Ogrenci Soyadı         : {0}", this.Soyisim);
            System.Console.WriteLine("Ogrenci No             : {0}", this.OgrenciNo);
            System.Console.WriteLine("Ogrenci Sınıfı         : {0}", this.Sinif);
        }
        public void SinifAtlat()
        {
            this.sinif += 1;
        }
        public void SinifDusur()
        {
            this.sinif -= 1;
        }

    }
}
