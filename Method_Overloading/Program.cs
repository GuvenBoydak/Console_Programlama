using System;

namespace Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Out parametreler
            string sayi = "999";

            bool sonuc=int.TryParse(sayi, out int OutSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(OutSayi);
            }
            else
            {
                Console.WriteLine("Başarısız!!");
            }

            Metodlar metodlar = new Metodlar();
            metodlar.Topla(5, 5, out int toplaSonuc);
            metodlar.EkranaYazdır(Convert.ToString(toplaSonuc));


            //Metot Aşırı yükleme - Overloading

            int ifade = 999;
            metodlar.EkranaYazdır(ifade );
            metodlar.EkranaYazdır("Güven", "Boydak");

        }
    }

    class Metodlar
    {
        public void Topla(int deger1,int deger2,out int topla)
        {
            topla = deger1 + deger2;
        }

        public void EkranaYazdır(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdır(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdır(string veri1,string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}
