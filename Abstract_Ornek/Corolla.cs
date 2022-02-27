using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Ornek
{
    public class Corolla : Otomobil
    {
        public override RenkEnum HangiRenk()
        {
            return RenkEnum.Beyaz;
        }
        public override MarkaEnum HangiMarka()
        {
            return MarkaEnum.Toyota;
        }
    }
}
