using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlarla_ilgili_algoritma_soruları_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

            Console.WriteLine("Lütfen bir cümle giriniz!!");

            string cümle = Console.ReadLine();

            char[] sesliharf = {'e','ı','o','ü','i','a','ö','u'};
            char[] cümleCharArray = cümle.ToCharArray();
            ArrayList dizi = new ArrayList();

            for (int i = 0; i < cümle.Length; i++)
            {
                if (sesliharf.Contains(cümle[i]))
                {
                    dizi.Add(cümle[i]);
                }
            }

            foreach (var item in dizi)
            {
                Console.WriteLine(item); ;
            }


            Console.ReadLine();
        }

     
    }
}
