using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherıtance
{
    public class Canlılar
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlılar Beslenir");
        }

        protected void Solunum()
        {
            Console.WriteLine("Canlılar Solunum yapar");
        }

        protected void Bosaltım()
        {
            Console.WriteLine("Canlılar Boşaltım yapar");
        }

        public virtual void UyaranalaraTepki()
        {
            Console.WriteLine("Canlılar Uyaranlara tepki verir.");
        }

    }
}
