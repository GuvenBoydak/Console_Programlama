using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama
            string[] renkler = new string[5];


            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Tavsan" };

            int[] dizi;
            dizi = new int[5];

            //Dizilere Deger Atama ve Erisim
            renkler[0] = "Mavi";
            dizi[3] = 10;
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngülerle dizi kullanımı
            //Klavyeden girilen n tane sayinin ortalamasını hesaplayınız.

            Console.Write("Lütfen bir Dizinin eleman sayisini giriniz: ");

            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz :", i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
                Console.WriteLine($"Toplam:{toplam} + Sayi: {sayi}");
            }

            Console.WriteLine("Ortalama : " + toplam / diziUzunlugu);


           
        }
    }
}
