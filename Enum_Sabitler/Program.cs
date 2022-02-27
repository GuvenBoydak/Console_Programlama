using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Sabitler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.pazartesi);
            Console.WriteLine((int)Gunler.pazartesi);

            int Derece = 32;
            if (Derece <=(int)HavaDurumu.soguk)
            {
                Console.WriteLine("Hava Çok Soguk");
            }
            else if (Derece <= (int)HavaDurumu.normal)
            {
                Console.WriteLine("Hava Normal");
            }
            else if (Derece <= (int)HavaDurumu.sıcak)
            {
                Console.WriteLine("Hava Sıcak");
            }else  
            {
                Console.WriteLine("Hava Çok sıcak");
            }

            Console.ReadLine();
        }
    }

    public enum Gunler
    {
        pazartesi,
        salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        PAzar
    }

    public enum HavaDurumu
    {
        soguk=5,
        normal=20,
        sıcak=25,
        çoksıcak=30
    }
}
