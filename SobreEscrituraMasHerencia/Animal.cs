using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreEscrituraMasHerencia
{
    class Animal
    {
        public virtual string  Comunicarse()
        {
            return "ruido... ruido... ";
        }

        public virtual string Atacar()
        {
            return "*lo ataca*";
        }

    }
}
