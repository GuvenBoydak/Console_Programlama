using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalişan Sayısı:{0}",Calisan.CalisanSayisi);
            Calisan calisan = new Calisan("Ayşe","Yılmaz","Ik");
            Console.WriteLine("Çalişan Sayısı:{0}", Calisan.CalisanSayisi);
            Calisan calisan2 = new Calisan("Deniz", "Kara", "Ik");
            Calisan calisan3 = new Calisan("Zikriye", "Ürkmez", "Ik");
            Console.WriteLine("Çalişan Sayısı:{0}", Calisan.CalisanSayisi);

            Console.WriteLine("Toplama İşlemi Sunucu:{0}",Islemler.Topla(100,200));
            Console.WriteLine("Çıkarma İşlemi Sunucu:{0}", Islemler.Cıkar(300, 200));


            Console.ReadLine();
        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;}

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim,string soyisim,string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }
    static class Islemler
    {
        public static long Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cıkar(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

    }
}
