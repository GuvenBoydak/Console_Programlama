using System;

namespace Tip_Donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {

            // implicit Conversion Bilinçsiz Dönüşüm

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d:" + d);

            long h = d;
            Console.WriteLine("h:" + h);

            float i = h;
            Console.WriteLine("i:" + i);

            string e = "Güven";
            char f = 'K';
            object g = e + f + d;
            Console.WriteLine("g:" + g);

            //Explicit Conversion Bilinçli Dönüşüm
          Console.WriteLine("******Explicit Conversion**********");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:" + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:" + t);

            float w = 10.3F;
            byte v = (byte)w;
            Console.WriteLine("v:" + v);

            // **** ToString Method ***
            Console.WriteLine("***** ToString Method ****");

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:" + yy);

            string zz = 12.5F.ToString();
            Console.WriteLine("zz:" + zz);

            //*** System.Convert ***
            Console.WriteLine("**** System.Convert sınıfı ****");

            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam:" + toplam);

            // **** Parse  ***
            Console.WriteLine("*** Parse Method ****");

            ParseMethod();
        }

        public static void ParseMethod()
        {
            string m1 = "10";
            string m2 = "10.25";
            int r1;
            double d1;

            r1 = Int32.Parse(m1);
            d1 = double.Parse(m2);
            Console.WriteLine("rakam1=" + r1);
            Console.WriteLine("double1 ="+ d1);

        }
    }

}
