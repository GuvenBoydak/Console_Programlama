using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            //arrayList.Add("Güven");
            //arrayList.Add(1);
            //arrayList.Add(true);
            //arrayList.Add('a');

            ////içerisindeki verilere erişim
            //Console.WriteLine(arrayList[1]);

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}


            //AddRange
            Console.WriteLine("******* AddRange ******");
            //string[] renkler = { "sarı", "kırmızı", "mavi" };
            //arrayList.AddRange(renkler);
            List<int> sayılar = new List<int> { 1, 4, 7, 2, 99, 44, 55 };
            arrayList.AddRange(sayılar);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //Sort
            Console.WriteLine("******* Sort ******");
            arrayList.Sort();

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //Binary Search
            Console.WriteLine("******* Binary Search ******");
            Console.WriteLine(arrayList.BinarySearch(99));

            //Reverse
            Console.WriteLine("******* REverse ******");

            arrayList.Reverse();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //Clear
            Console.WriteLine("******* Clear ******");

            arrayList.Clear();

            Console.ReadLine();
        }
    }
}
