using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayşe";
            ogrenci.Soyisim = "yılmaz";
            ogrenci.OgrenciNo = 293;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SınıfAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Deniz","Arda",256,1);
            ogrenci1.SınıfDusur();
            ogrenci1.SınıfDusur();

            ogrenci1.OgrenciBilgileriniGetir();


            Console.ReadLine();
        }
    }
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }

        public string Soyisim { get => soyisim; set => soyisim = value; }

        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }

        public int Sinif
        {
            get => sinif;
            set
            {
                if (value<1)
                {
                    Console.WriteLine("Sınıf En az 1 olabilir!");
                    sinif = 1;
                }
                else
                {
                    sinif = value;
                }
            }
        }


        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci()
        {

        }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("***********Ögrenci Bilgileri***********");
            Console.WriteLine("Ögrenci Adı      :{0}", this.Isim);
            Console.WriteLine("Ögrenci Soyisim  :{0}", this.Soyisim);
            Console.WriteLine("Ögrenci No       :{0}", this.OgrenciNo);
            Console.WriteLine("Ögrenci sınıf    :{0}", this.Sinif);

        }

        public void SınıfAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SınıfDusur()
        {
            this.Sinif = this.Sinif - 1;
        }
    }
}
