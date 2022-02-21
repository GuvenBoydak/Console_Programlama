using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurucu_metot
{
    class Program
    {
        static void Main(string[] args)
        {

            Calısan calısan = new Calısan("Ayşe","Kara");

            calısan.CalısanBilgileri();

            Console.WriteLine("*******Çalişan 2*********");
            Calısan calısan1 = new Calısan("Arda","Deniz",25646789,"Satın Alma");

            calısan1.CalısanBilgileri();



            Console.ReadLine();
        }
    }
    class Calısan
    {
        public Calısan(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
        }


        public Calısan(string ad,string soyad,int no,string departman)
        {
            Ad = ad;
            Soyad = soyad;
            No = no;
            Departman = departman;
        }


        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalısanBilgileri()
        {
            Console.WriteLine("Çalişan Ad:{0}", Ad);
            Console.WriteLine("Çalişan Soyad:{0}", Soyad);
            Console.WriteLine("Çalişan No:{0}", No);
            Console.WriteLine("Çalişan Departman:{0}", Departman);
        }
    }
}
