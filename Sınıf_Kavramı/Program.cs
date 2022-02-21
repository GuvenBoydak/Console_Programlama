using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıf_Kavramı
{
    class Program
    {
        static void Main(string[] args)
        {
            // söz dizilimi
            //class sınıfAdi
            //[Erişim belirteci][Veri Tibi] Özellikler;

            //[Erişim belirteci][Geri Dönüş tipi] MetotAdi(parametre listesi)
            //{
            //Metot komutları
            //}

            //Erişim belirteciler
            //  public  
            //  private
            //  internal
            //  protected

            Calısan calısan = new Calısan();
            calısan.Ad = "Ayşe";
            calısan.Soyad = "Kara";
            calısan.No = 23425634;
            calısan.Departman = "İnsan Kaynakları";

            calısan.CalısanBilgileri();


            Calısan calısan1 = new Calısan();
            calısan1.Ad = "Arda";
            calısan1.Soyad = "Deniz";
            calısan1.No = 25646789;
            calısan1.Departman = "Satın Alma";

            calısan1.CalısanBilgileri();


            Console.ReadLine();
        }
    }

    class Calısan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalısanBilgileri()
        {
            Console.WriteLine("Çalişan Ad:{0}" , Ad);
            Console.WriteLine("Çalişan Soyad:{0}", Soyad);
            Console.WriteLine("Çalişan No:{0}", No);
            Console.WriteLine("Çalişan Departman:{0}", Departman);
        }
    }
}
