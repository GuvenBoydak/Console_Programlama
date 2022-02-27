using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Ornek
{
    public class ArabaManager : IOtomobil
    {
        public IOtomobil _otomobil;
        public ArabaManager(IOtomobil otomobil)
        {
            _otomobil = otomobil;
        }

        public MarkaEnum HangiMarka()
        {
            return _otomobil.HangiMarka();
        }

        public RenkEnum HangiRenk()
        {
            return _otomobil.HangiRenk();
        }

        public int KacTekerlektenOlusur()
        {
            return _otomobil.KacTekerlektenOlusur();
        }
    }
}
