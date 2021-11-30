using System;
using System.Collections.Generic;
namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T-> object türündedir.

            List<int> sayiList = new List<int>();
            sayiList.Add(23);
            sayiList.Add(2421);
            sayiList.Add(21);
            sayiList.Add(24);
            sayiList.Add(5);
            sayiList.Add(92);
            sayiList.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Yeşil");
            renkListesi.Add("Sarı");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiList.Count);

            //Foreach ve List.ForEach ile elemanlara erşim
            foreach (var item in sayiList)
            {
                Console.WriteLine(item);
            }
            
            sayiList.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));
        
            //Listeden eleman çıkarma
            sayiList.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiList.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiList.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //liste içersinde arama
            if(sayiList.Contains(10)){
                Console.WriteLine("10 liste içersinde");
            }

            //Eleman ile indexe erişme
            Console.WriteLine(renkListesi.BinarySearch("kırmızı"));

            //Diziyi liste çevirme 
            string[] hayvanlar = {"Kedi","kopek","kuş"};
            List<string> hayvanlarListesi= new List<string>(hayvanlar);

            //Listeyi temizleme
            hayvanlarListesi.Clear();

            //liste içerisnde nesne tutmak
            List<Kullanıcılar> kullanıcıListesi=new List<Kullanıcılar>();
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Ayşe";
            kullanıcı1.Soyisim = "Yılmaz";
            kullanıcı1.Yas= 26;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "fatih ";
            kullanıcı2.Soyisim = "Topcu";
            kullanıcı2.Yas= 23;
            
            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar(){
                Isim = "fatih",
                Soyisim = "Topcu",
                Yas = 21
            });
            
            foreach (Kullanıcılar kullanıcı in kullanıcıListesi)
            {
                System.Console.WriteLine("Kullanıcı Adı " + kullanıcı.Isim);
                System.Console.WriteLine("Kullanıcı SoyAdı " + kullanıcı.Soyisim);
                System.Console.WriteLine("Kullanıcı Yaş " + kullanıcı.Yas);
            }
        }
    }
    public class Kullanıcılar
    {
        string isim;
        string soyisim;
        int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
