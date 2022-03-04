using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberUygulaması.Entity
{
    public static class TelefonRehberi
    {
        public static List<TelefonNumaralari> TelNumaralari = new List<TelefonNumaralari>();




        public static void YapmakIstediginizIslem()
        {
            Console.WriteLine("Lütfen Yapmak istediginiz işlemi seciniz");
            Console.WriteLine("********************************");
            Console.WriteLine("1- Yeni Numara Kaydet");
            Console.WriteLine("2- Var olan Numarayi sil");
            Console.WriteLine("3- Var olan Numarayi Güncelle");
            Console.WriteLine("4- Rehberi Listele");
            Console.WriteLine("5- Rehberden Arama Yap");

            int Secim = int.Parse(Console.ReadLine());
            if (Secim <= 0 || Secim > 5)
            {
                Console.WriteLine("Yanlış Seçim yaptınız!!!!!! \n Lütfen Listeden Seçim Yapınız.");
                YapmakIstediginizIslem();
            }
            switch (Secim)
            {
                case 1:
                    TelefonRehberi.Kaydet();
                    break;
                case 2:
                    TelefonRehberi.Sil();
                    break;
                case 3:
                    TelefonRehberi.Güncelle();
                    break;
                case 4:
                    TelefonRehberi.Listele();
                    break;
                case 5:
                    TelefonRehberi.RehberdeAra();
                    break;
                default:
                    break;
            }
        }

        public static void Kaydet()
        {
            Console.Write("Lütfen İsim Giriniz             :");
            string name = Console.ReadLine();
            Console.Write("Lütfen Soyisim Giriniz          :");
            string LastName = Console.ReadLine();
            Console.Write("Lütfen Telefon Numarası Giriniz :");
            string TelNumber = Console.ReadLine();
            TelefonNumaralari telefonNumaralari6 = new TelefonNumaralari(name, LastName, TelNumber);
        }

        public static void Sil()
        {
            Console.Write("Lütfen Silmek İstediginiz Kişinin Adını veya Soyisim Yazınız : ");
            string deger = Console.ReadLine();
            int sayac = 0;
            foreach (var item in TelNumaralari)
            {
                if (item.Name == deger || item.LastName == deger)
                {
                    sayac++;
                }
            }

            if (sayac > 0)
            {
                Console.WriteLine($"{deger} kişisini rehberden silinmek üzere,Onaylıyor musunuz?? E/H");
                string yanıt = Console.ReadLine();


                if (yanıt == "E")
                {
                    foreach (var item in TelNumaralari)
                    {
                        if (item.Name == deger || item.LastName == deger)
                        {
                            TelNumaralari.Remove(item);
                            Console.WriteLine($"{item.Name} {item.LastName} kişi Silindi.");
                            break;
                        }                                         
                    }
                }
            }
            else
            {
                Console.WriteLine("Aradıgınız kiriterlere uygun veri bulunamadı,Lütfen Seçim Yapın!!!");
                Console.WriteLine("Silmeyi sonlandırmak için : 1");
                Console.WriteLine("Tekrar Denemek için       : 2");
                int cevap1 = int.Parse(Console.ReadLine());
                if (cevap1 == 1)
                {
                    Console.WriteLine("İşlem Sonlandırıldı!!!");
                }
                else if(cevap1==2)
                {
                    Sil();
                }
            }
        }

        public static void Güncelle()
        {
            Console.WriteLine("Lütfen numarasını Güncellemek istediginiz kişinin Adını veya Soyismini Yazınız!!!");
            string deger = Console.ReadLine();
            int sayac = 0;

            foreach (var item in TelNumaralari)
            {
                if (item.Name == deger || item.LastName == deger)
                {
                    sayac++;
                }
            }
            

            if (sayac>0)
            {
                Console.WriteLine($"{deger} kişisinin Bilgilerini rehberden Güncellemek üzere,Onaylıyor musunuz?? E/H");
                string yanıt = Console.ReadLine();
                if (yanıt=="E")
                {
                    foreach (var item in TelNumaralari)
                    {
                        if (item.Name == deger || item.LastName == deger)
                        {
                            Console.WriteLine($"Lütfen Degiştirmek istediginiz {item.Name} {item.LastName} {item.PhoneNumber} degeri Yazınız!!!");
                            Console.Write($"{item.Name} ile Güncellenecek İsmi Giriniz. / Degiştirmek istemiyorsanız aynı ismi giriniz.");
                            string isim = Console.ReadLine();
                            item.Name = isim;

                            Console.Write($"{item.LastName} ile Güncellenecek İsmi Giriniz. / Degiştirmek istemiyorsanız aynı ismi giriniz.");
                            string soyisim = Console.ReadLine();
                            item.LastName = soyisim;

                            Console.Write($"{item.PhoneNumber} ile Güncellenecek İsmi Giriniz. / Degiştirmek istemiyorsanız aynı ismi giriniz.");
                            string telefon = Console.ReadLine();
                            item.PhoneNumber = telefon;
                            Console.WriteLine("Bilgiler Güncellendi!!!");
                        }
                        
                    }
                }
            }
            else
            {
                Console.WriteLine("Aradıgınız kiriterlere uygun veri bulunamadı,Lütfen Seçim Yapın!!!");
                Console.WriteLine("Güncellemeyi sonlandırmak için : 1");
                Console.WriteLine("Tekrar Denemek için       : 2");
                int cevap1 = int.Parse(Console.ReadLine());
                if (cevap1 == 1)
                {
                    Console.WriteLine("İşlem Sonlandırıldı!!!");
                }
                else if (cevap1 == 2)
                {
                    Güncelle();
                }
            }

        }

        public static void Listele()
        {
            Console.WriteLine("Telefon Rehberi");
            foreach (var item in TelNumaralari)
            {
                Console.WriteLine($"İsim       : {item.Name}");
                Console.WriteLine($"Soyisim    : {item.LastName}");
                Console.WriteLine($"Telefon no : {item.PhoneNumber}");
            }
            Console.WriteLine("----");
        }

        public static void RehberdeAra()
        {
            Console.WriteLine("Arama yapmak istediginiz tipi seçiniz!!!");
            Console.WriteLine("********************");

            Console.WriteLine("İsim veya Soyisime göre Arama yapmak için : 1 ");
            Console.WriteLine("Telefon Numarasina göre Arama yapmak için : 2 ");
            int cevap = int.Parse(Console.ReadLine());
            if (cevap==1)
            {
                Console.WriteLine("Aramak İstediginiz Degerin İsmini veya Soyismini Giriniz!!");
                string deger = Console.ReadLine();
                foreach (var item in TelNumaralari)
                {
                    if (deger==item.Name || deger==item.LastName)
                    {
                        Console.WriteLine($"İsim       : {item.Name}");
                        Console.WriteLine($"Soyisim    : {item.LastName}");
                        Console.WriteLine($"Telefon no : {item.PhoneNumber}");
                    }
                    else
                    {

                        Console.WriteLine("Aramak İstediginiz İsmini veya Soyismini bulunamadı!! / Tekrar Denemek İstermisiniz E/H ?");
                        char cevap1 = Convert.ToChar(Console.ReadLine());
                        if (cevap1 == 'E')
                        {
                            RehberdeAra();
                        }
                    }                   
                }
            }
            else
            {
                Console.WriteLine("Aramak İstediginiz Degerin Telefon Numarasını Giriniz!!");
                string deger = Console.ReadLine();
                foreach (var item in TelNumaralari)
                {
                    if (deger == item.PhoneNumber)
                    {
                        Console.WriteLine($"İsim       : {item.Name}");
                        Console.WriteLine($"Soyisim    : {item.LastName}");
                        Console.WriteLine($"Telefon no : {item.PhoneNumber}");
                    }
                    else
                    {
                        Console.WriteLine("Aramak İstediginiz Telefon Numarası bulunamadı!! / Tekrar Denemek İstermisiniz E/H ?");
                        char cevap2 =Convert.ToChar(Console.ReadLine());
                        if (cevap2=='E')
                        {
                            RehberdeAra();
                        }
                    }
                   
                }
            }
        }
    }
}
