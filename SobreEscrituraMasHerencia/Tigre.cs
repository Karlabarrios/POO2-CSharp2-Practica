using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreEscrituraMasHerencia
{
    class Tigre : AnimalSalvaje
    {
        public override string Comunicarse()
        {
            return "Roar roar";
        }
        public override string Atacar()
        {
            return "*lo ataca a muerte velozmente*";
        }
    }
}
