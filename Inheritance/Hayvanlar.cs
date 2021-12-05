using System;

namespace Inheritance
{
    public class Hayvanlar : Canlilar
    {
        protected void Adaptasyon()
        {
            System.Console.WriteLine("Hayvanlar adapte olabilir");
        }
    }
    public class Sürüngenler : Hayvanlar
    {
        public Sürüngenler()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void SurunerekHareket()
        {
            System.Console.WriteLine("sürünerek hareket eder");
        }
    }
    public class Kuslar : Hayvanlar
    {
        public Kuslar()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void Ucmak()
        {
            System.Console.WriteLine("uçarlar");
        }
    }
}
