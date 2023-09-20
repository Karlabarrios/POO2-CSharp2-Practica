using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreEscrituraMasHerencia
{
    class Gato : AnimalDomestico
    {
        public override string Comunicarse()
        {
            return "Miau miau";
        }
    }
}
