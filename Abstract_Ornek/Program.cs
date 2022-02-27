using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.KacTekelekli());
            Console.WriteLine(focus.HangiMarka());
            Console.WriteLine(focus.HangiRenk());


            Civic civic = new Civic();
            Console.WriteLine(civic.KacTekelekli());
            Console.WriteLine(civic.HangiMarka());
            Console.WriteLine(civic.HangiRenk());

            Console.ReadLine();
        }
    }
}
