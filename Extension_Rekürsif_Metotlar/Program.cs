using System;

namespace Extension_Rekürsif_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reküstif - Öz yinelemeli

            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result = result * 3;
            }
            Console.WriteLine(result);

            Islemler ıslemler = new();
            Console.WriteLine(Islemler.Expo(3,4)); ;


            //Extension metotlar
            string ifade = "Zikriye ürkmez cengiz";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);

            Console.WriteLine(ifade.RemoveWhiteSpaces());

            Console.WriteLine(ifade.MakeLowerCase());

            Console.WriteLine(ifade.MakeUpperCase());

            int[] dizi = {3,5,9,4,6,1,0};
            dizi.SortArray();
            dizi.EkranaYazdır();

            int sayi = 5;
            Console.WriteLine(sayi.IsEven()); 

            Console.WriteLine(ifade.GetFirstCharacter());
            

           
        }
    }

    public class Islemler
    {
        public static int Expo(int sayi,int üs)
        {
            if (üs<2)
            {
                return sayi;
            }

            return Expo(sayi, üs - 1) * sayi;
        }
    }

    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("*",dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdır(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }

        public static bool IsEven(this int param)
        {
            return param % 2 == 0;
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }
    }
}
