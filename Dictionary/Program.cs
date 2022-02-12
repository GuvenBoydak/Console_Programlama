using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kulanıcılar = new Dictionary<int, string>();
            kulanıcılar.Add(10,"Ayşe Yılmaz");
            kulanıcılar.Add(12, "Ahmet Yılmaz");
            kulanıcılar.Add(18, "Deniz Arda");
            kulanıcılar.Add(20, "Özcan Çoşar");

            //Dizinin Elemanlarına erişim
            Console.WriteLine("******* Elemanlara Erisim******");
            Console.WriteLine(kulanıcılar[12]);
            foreach (var item in kulanıcılar)
            {
                Console.WriteLine(item);
            }

            //Count
            Console.WriteLine("*******Count******");
            Console.WriteLine(kulanıcılar.Count());

            //Contains
            Console.WriteLine("*******Contains******");
            Console.WriteLine(kulanıcılar.ContainsKey(12));
            Console.WriteLine(kulanıcılar.ContainsValue("Zikriye ürkmez"));

            //REmove
            Console.WriteLine("*******Remove******");
            kulanıcılar.Remove(12);
            foreach (var item in kulanıcılar)
            {
                Console.WriteLine(item.Value);
            }

            //Values
            Console.WriteLine("********Values******");
            foreach (var item in kulanıcılar)
            {
                Console.WriteLine(item.Value);
            }

            //Keys 
            Console.WriteLine("********Keys******");
            foreach (var item in kulanıcılar)
            {
                Console.WriteLine(item.Key);
            }

            Console.ReadLine();
        }
    }
}
