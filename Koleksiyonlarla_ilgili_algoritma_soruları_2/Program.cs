using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlarla_ilgili_algoritma_soruları_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

            ArrayList liste = new ArrayList();
            ArrayList enBüyük = new ArrayList();
            ArrayList enKücük = new ArrayList();

            for (int i = 0; i < 6; i++)
            {
                Console.Write("{0}. Sayıyı giriniz!!", i + 1);
                try
                {
                    int sayi = int.Parse(Console.ReadLine());                  
                    liste.Add(sayi);
                }
                catch (Exception)
                {
                    throw new Exception("lütfen Sayi giriniz.");
                }             
            }

            
            liste.Sort();           
            Console.WriteLine("En Küçük Sayıların Toplamı: " + EnkücükBulVeTopla(liste, enKücük));
            EkranaYaz(enKücük);
            int toplamEnkücük = enKücük.Count;
            int EnkücükToplamSayı = EnkücükBulVeTopla(liste, enKücük);
            double ortalama = EnkücükToplamSayı / toplamEnkücük;
            Console.WriteLine("En Kücük Sayıların Ortalaması: " +ortalama);

            Console.WriteLine("-----------------------------");

            liste.Reverse();          
            Console.WriteLine("En Büyük Sayıların Toplamı: " + EnBüyükBulVeTopla(liste, enBüyük));
            EkranaYaz(enBüyük);
            int toplamEnBüyük = enBüyük.Count;
            int EnbüyükToplamSayı = EnBüyükBulVeTopla(liste, enBüyük);
            double ortalama1 = EnbüyükToplamSayı / toplamEnBüyük;
            Console.WriteLine("En Büyük Sayıların Ortalaması: " + ortalama1);

            Console.WriteLine("------------------------");
            Console.WriteLine("En Büyük ve En Kücük Sayıların Toplam Ortalamaları: " + ortalama+ortalama1);


            Console.ReadLine();
        }

        public static void EkranaYaz(ArrayList param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }

        public static int EnkücükBulVeTopla(ArrayList liste, ArrayList param)
        {
            int toplamenkücük = 0;
            for (int i = 0; i < 3; i++)
            {
                param.Add(liste[i]);
                toplamenkücük += Convert.ToInt32(liste[i]);
            }
            return toplamenkücük;
        }
        public static int EnBüyükBulVeTopla(ArrayList liste, ArrayList param)
        {
            int toplamenbüyük = 0;
            for (int i = 0; i < 3; i++)
            {
                param.Add(liste[i]);
                toplamenbüyük += Convert.ToInt32(liste[i]);
            }
            return toplamenbüyük;
        }
    }
}
