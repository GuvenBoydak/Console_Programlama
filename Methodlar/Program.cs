using System;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erişim_belirteci Geri_dönüşTipi Metot_adi(ParametreListesi/Arguman)
            //{
            //Komutlar;
            //return;
            //}

            int a = 2;
            int b = 3;
            Console.WriteLine(a+b);

            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);

            Metodlar ornek = new Metodlar();
            ornek.EkranaYazdır(Convert.ToString(sonuc));


            int sonuc2 = ornek.ArtırVeTopla(ref a,ref b);
            ornek.EkranaYazdır(Convert.ToString(sonuc2));
            ornek.EkranaYazdır(Convert.ToString(a+b));

        }

        static int Topla(int deger1,int deger2)
        {
            return deger1 + deger2;
        }

    }

    class Metodlar
    {
        public void EkranaYazdır(string veri)
        {
            Console.WriteLine(veri);
        }


        public int ArtırVeTopla(ref int deger1,ref int deger2)
        {
            deger1++;
            deger2++;
            return deger1 + deger2;
        }
    }
}
