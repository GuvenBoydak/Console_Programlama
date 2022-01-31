using System;

namespace For_Dongüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrana girilen sayıya kadar olan tek sayıları ekrana yazdır.
            Console.WriteLine("Ekrane bir Sayı giriniz!!");
            int sayi = int.Parse(Console.ReadLine());
            for (int i = 1; i < sayi; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("Tek Sayı " + i);
                }
            }


            // 1 ile 1000 arasındakı tek ve çift sayıların toplamlarını ekrana yazdır.

            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tekToplam += i;
                }
                else
                {
                    ciftToplam += i;
                }
            }
            Console.WriteLine("Tek Sayiların Toplamı " + tekToplam);
            Console.WriteLine("Çift Sayilarin Toplamı " + ciftToplam);



            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }





        }
    }
}
