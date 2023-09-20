using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreEscrituraMasHerencia
{
    class AnimalSalvaje : Animal
    {
        public override string Atacar()
        {
            return "*lo ataca a muerte*";
        }
    }
}
