using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            ArabaManager arabaManager = new ArabaManager(new Civic());
            Console.WriteLine(arabaManager.KacTekerlektenOlusur());
            Console.WriteLine(arabaManager.HangiMarka());
            Console.WriteLine(arabaManager.HangiRenk());

            Console.ReadLine();
        }
    }
}
