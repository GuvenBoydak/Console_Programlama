using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlarla_ilgili_algoritma_soruları
{
    class Program
    {
        static void Main(string[] args)
        {

            //Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

            //Negatif ve numeric olmayan girişleri engelleyin.
            //Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            //Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

            ArrayList liste = new ArrayList();
            ArrayList asallar = new ArrayList();
            ArrayList asalOlmayanlar = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Pozitif {0}. Sayıyı giriniz!!", i + 1);
                try
                {
                    int sayi = int.Parse(Console.ReadLine());
                    if (sayi < 0)
                    {
                        Console.WriteLine("Pozitif sayı giriniz.");
                        i--;
                    }
                    else
                    {
                        if (Asal(sayi))
                        {
                            asallar.Add(sayi);
                        }
                        else
                        {
                            asalOlmayanlar.Add(sayi);
                        }
                    }
                }
                catch (Exception)
                {
                    throw new Exception("Numeric olmayan karakter girilmez.");
                }
            }



            Console.WriteLine("---------------------------Sayıları Büyükten Küçüge Sırala");

            asallar.Reverse();
            asalOlmayanlar.Sort();
            asalOlmayanlar.Reverse();

            EkranaYaz(asallar);
            Console.WriteLine("*****************");
            EkranaYaz(asalOlmayanlar);

            Console.WriteLine("---------------------------Toplam Eleman Sayılarını Hesapla!!!");

            Console.WriteLine("Asal olan Sayıların toplam sayısı: " + ToplamAsallar(asallar));
            Console.WriteLine("*****************");
            Console.WriteLine("Asal Olmayan Sayıların toplam sayısı: " + ToplamAsalOlmayanlar(asalOlmayanlar));

            Console.WriteLine("---------------------------Ortalama hesapla!!!!");

            Console.WriteLine("Asal Sayıların Ortalaması: " + AsalOrtalama(asallar));
            Console.WriteLine("*****************");
            Console.WriteLine("Asal Sayıların Ortalaması: " + AsalOlmayanlarınOrtalaması(asalOlmayanlar));



            Console.ReadLine();
        }

        public static bool Asal(int sayi1)
        {
            if (sayi1 == 1 || sayi1 == 0)
            {
                return false;
            }

            for (int i = 2; i < sayi1; i++)
            {
                if (sayi1 % i == 0)
                {
                    return false;
                }

            }
            return true;
        }

        public static void EkranaYaz(ArrayList param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }

        public static int ToplamAsallar(ArrayList param)
        {

            int toplamasallar = 0;
            for (int i = 0; i < param.Count; i++)
            {
                toplamasallar++;
            }
            return toplamasallar;
        }

        public static int ToplamAsalOlmayanlar(ArrayList param)
        {
            int toplamAsalolmayanlar = 0;
            for (int i = 0; i < param.Count; i++)
            {
                toplamAsalolmayanlar++;
            }
            return toplamAsalolmayanlar;
        }

        public static double AsalOrtalama(ArrayList param)
        {
            int toplam = 0;
            int sayac = 0;
            foreach (int item in param)
            {
                toplam += item;
                sayac++;
            }
            double ortalama = toplam / sayac;
            return ortalama;
        }
        public static double AsalOlmayanlarınOrtalaması(ArrayList param)
        {
            int toplam = 0;
            int sayac = 0;
            foreach (int item in param)
            {
                toplam += item;
                sayac++;
            }
            double ortalama = toplam / sayac;
            return ortalama;
        }
    }
}