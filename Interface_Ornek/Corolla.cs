using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Ornek
{
    public class Corolla : IOtomobil
    {
        public MarkaEnum HangiMarka()
        {
            return MarkaEnum.Toyota;
        }

        public RenkEnum HangiRenk()
        {
            return RenkEnum.Gri;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }
    }
}
