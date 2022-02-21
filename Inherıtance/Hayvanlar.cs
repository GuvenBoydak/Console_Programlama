using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherıtance
{
    public class Hayvanlar : Canlılar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptan kurabilir.");
        }
    }

    public class Sürüngenler:Hayvanlar
    {
        public Sürüngenler()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltım();
            base.Solunum();
        }
        public void SurunerekHareketEtmek()
        {
            Console.WriteLine("sürüngenlere sürünerek hareket eder.");
        }
    }

    public class Kuslar : Hayvanlar
    {
        public Kuslar()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltım();
            base.Solunum();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuşlar uçar");
        }
    }
}
