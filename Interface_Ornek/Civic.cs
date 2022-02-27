using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Ornek
{
    public class Civic : IOtomobil
    {
        public MarkaEnum HangiMarka()
        {
            return MarkaEnum.Honda;
        }

        public RenkEnum HangiRenk()
        {
            return RenkEnum.Beyaz;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }
    }
}
