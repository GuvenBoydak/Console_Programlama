using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);


            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(sayiListesi.Count());
            Console.WriteLine(renkListesi.Count());

            //Foreach ve List.Foreach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);
            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste İçerisinde Arama
            if (sayiListesi.Contains(10))
            {
                Console.WriteLine("Liste içinde bulundu");
            }

            //Eleman ile İndexe Erişme
            Console.WriteLine(sayiListesi.BinarySearch(34));
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            //Diziyi List'e Çevirme
            string[] hayvanlar = { "kedi", "Köpek", "kuş" };
            List<string> hayvanlistesi = new List<string>(hayvanlar);
            hayvanlistesi.ForEach(hayvan => Console.WriteLine(hayvan));

            //Listeyi nasıl Temizleriz
            hayvanlistesi.Clear();

            //List içerisinde nesne tutmak
            List<Kullanıcılar> kullanıcılistesi = new List<Kullanıcılar>();
            Kullanıcılar kullanıcılar1 = new Kullanıcılar();
            kullanıcılar1.Isim = "Ayşe";
            kullanıcılar1.Soyisim = "Yılmaz";
            kullanıcılar1.Yas = 26;

            Kullanıcılar kullanıcılar2 = new Kullanıcılar();
            kullanıcılar2.Isim = "Özcan";
            kullanıcılar2.Soyisim = "Çalişkan";
            kullanıcılar2.Yas = 26;

            kullanıcılistesi.Add(kullanıcılar1);
            kullanıcılistesi.Add(kullanıcılar2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar()
            {
                Isim = "Deniz",
                Soyisim="Arda",
                Yas=24
            });

            foreach (Kullanıcılar kullanıcı in kullanıcılistesi)
            {
                Console.WriteLine("Kulanıcı Adı: " + kullanıcı.Isim);
                Console.WriteLine("Kulanıcı Soyisim: " + kullanıcı.Soyisim);
                Console.WriteLine("Kulanıcı Yaşı: " + kullanıcı.Yas);
            }

            Console.ReadLine();
        }
    }
    public class Kullanıcılar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
