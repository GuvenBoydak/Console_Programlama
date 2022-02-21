using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherıtance
{
    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.TohumlaCogalırlar();

            Console.WriteLine("***************");
            
            Kuslar martı = new Kuslar();
            martı.Ucmak();

            Console.ReadLine();


        }
    }
}
