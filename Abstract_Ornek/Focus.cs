using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Ornek
{
    public class Focus : Otomobil
    {
        public override RenkEnum HangiRenk()
        {
            return RenkEnum.Gri;
        }

    }
}
