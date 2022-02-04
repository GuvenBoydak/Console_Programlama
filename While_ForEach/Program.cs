using System;

namespace While_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {

            //1 den başlayarak console dan girilen sayi kadar (sayi dahil) ortalama hesaplayıp console a  yazdırın.

            Console.Write("Lütfen Bir sayı giriniz!!!");
            int sayi = int.Parse(Console.ReadLine());
            int toplam = 0;
            int sayac = 1;

            while (sayac<=sayi)
            {
                toplam += sayac;
                sayac++;
                Console.WriteLine($"Toplam: {toplam} + {sayac}");
            }

            Console.WriteLine(toplam/sayi);

            //'a' dan 'z' ye kadar olan harfleri console a yazdırın.
            char character = 'a';

            while (character<'z')
            {
                Console.Write(character);
                character++;
            }

            Console.WriteLine("********** Foreach ***********");

            string[] Arabalar = { "Bmw", "Opel", "Audi", "RangeRover", "Ford" };

            foreach (var araba in Arabalar)
            {
                Console.WriteLine(araba);
            }


        }
    }
}
