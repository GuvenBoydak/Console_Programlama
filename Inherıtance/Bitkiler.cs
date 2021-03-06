using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherıtance
{
    public class Bitkiler : Canlılar
    {

        protected void FotosentezYapmak()
        {
            Console.WriteLine("Bitkiler fotosentez yapar");
        }

        public override void UyaranalaraTepki()
        {
            //base.UyaranalaraTepki();
            Console.WriteLine("Bitikler Güneşe Tepki verir.");
        }
    }

    public class TohumluBitkiler : Bitkiler
    {
        public TohumluBitkiler()
        {
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltım();
            base.Solunum();
            base.UyaranalaraTepki();
        }
        public void TohumlaCogalırlar()
        {
            Console.WriteLine("Tohumlu bitkiler tohumlar çogalır.");
        }
    }
    public class TohumsuzBitkiler:Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.FotosentezYapmak();
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltım();
            base.Solunum();
        }
        public void TohumsuzCogalırlar()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla çogalır.");
        }
    }

}
