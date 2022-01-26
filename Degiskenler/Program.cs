using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5;     //1 byte
            sbyte sb = 5;   //1 byte

            short s = 5;    //2 byte
            ushort us = 5;  //2 byte

            Int16 i16 = 2; //2 byte
            int i = 2;     //4 byte
            Int32 i32 = 2; //4 byte
            Int64 i64 = 2; //8 byte

            uint ui = 2;   //4 bye
            long l = 4;    //8 byte
            ulong ul = 4;  //8 byte

            //Real sayılar
            float f = 5;    //4 byte
            double d = 5;   //8 byte
            decimal de = 5; //16 byte

            char c = '2';          //2 byte
            string str = "güven"; //sınırsız

            bool b1 = true;     
            bool b2 = false;    

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = "y";
            object o3 = 4;
            object o4 = 4.3;

            //String ifadeler

            string str1 = string.Empty;
            str = "Güven Boydak";
            string ad = "Güven";
            string soyad = "Boydak";
            string tamisim = ad + " " + soyad;


            //Integer tanımlama sekilleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 + integer2;

            //boolen

            bool bool1 = 10 < 2;


            //Degisim Dönüsümleri

            string str20 = "20";
            int int20 = 20;
            string yenideger = str20 + int20.ToString();
            Console.WriteLine(yenideger); // Cıktısı 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); // Cıktısı 40


            int int22 = int20 + int.Parse(str20); // Cıktısı 40


            //Datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd-mm-yyyy");
            Console.WriteLine(datetime2);

            //Saat

            string Hour = DateTime.Now.ToString("hh:mm");
            Console.WriteLine(Hour);

            Console.ReadLine();




















        }

    }
}
