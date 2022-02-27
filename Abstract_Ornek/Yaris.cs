using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Ornek
{
    public class Yaris : Otomobil
    {
        public override RenkEnum HangiRenk()
        {
            return RenkEnum.Kırmızı;
        }

        public override MarkaEnum HangiMarka()
        {
            return MarkaEnum.Toyota;
        }
    }
}
