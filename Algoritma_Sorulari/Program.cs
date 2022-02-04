using System;

namespace Algoritma_Sorulari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            Console.Write("Lütfen Pozitif bir Sayi Giriniz: ");

            int sayi = int.Parse(Console.ReadLine());
            int[] sayilar = new int[sayi];

            for (int i = 0; i < sayi; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz: ", i + 1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            foreach (var s in sayilar)
            {
                if (s % 2 == 0)
                {
                    Console.Write($"{s} - " );
                }
            }


            Console.WriteLine();
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            Console.WriteLine("Lütfen Pozitif iki Sayi Giriniz: ");

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[] rakamlar = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz: ", i + 1);
                rakamlar[i] = int.Parse(Console.ReadLine());
            }
            foreach (var r in rakamlar)
            {
                if (r == m || r % m == 0)
                {
                    Console.Write($"{r} - ");
                }
            }

            Console.WriteLine();
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            Console.WriteLine("Lütfen Pozitif bir Sayi Giriniz: ");

            int sayi2 = int.Parse(Console.ReadLine());
            string[] kelime = new string[sayi2];

            for (int i = 0; i < sayi2; i++)
            {
                Console.Write("Lütfen {0}. Kelimeyi giriniz: ", i + 1);
                kelime[i] = Console.ReadLine();
            }

            int sondan = kelime.Length - 1;

            for (int i = sondan; i >= 0; i--)
            {
                Console.WriteLine(kelime[i]);
            }

            Console.WriteLine();
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.WriteLine("Bir Cümle yazınız!!");

            string cümle = Console.ReadLine();
            string[] cümleDizisi = cümle.Split(' ');
            char[] Harfler = cümle.ToCharArray();

            int kelimeSayısı = 0;
            foreach (var c in cümleDizisi)
            {
                kelimeSayısı++;

            }
            Console.WriteLine("Toplam Kelime Sayısı: " + kelimeSayısı);

            int harfSayısı = 0;
            foreach (var h in Harfler)
            {
                harfSayısı++;
            }
            Console.WriteLine("Toplam Harf Sayısı: " + harfSayısı);


        }
    }
}
