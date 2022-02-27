using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Ornek
{
    public abstract class Otomobil
    {
        public int KacTekelekli()
        {
            return 4;
        }

        public virtual MarkaEnum HangiMarka()
        {
            return MarkaEnum.Ford;
        }
        public abstract RenkEnum HangiRenk();
   
    }
}
