using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreEscrituraMasHerencia
{
    class AnimalDomestico : Animal
    {
        public string Nombre { get; set; }

        public override string Atacar()
        {
            return "*lo ataca jugando*";
        }
    }
}
