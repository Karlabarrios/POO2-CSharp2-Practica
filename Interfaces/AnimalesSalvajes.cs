using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class AnimalesSalvajes : Animal
    {
        public override string Atacar()
        {
            return "*Lo ataca a muerte*";
        }
        public override string Atacar(string sujeto)
        {
            return "*Ataca a muerte a " + sujeto + " *";
        }
        public override string Comunicarse()
        {
            return "*hace un sonido o movimiento salvaje*";
        }
        public override string Comunicarse(string sujeto)
        {
            return "*hace un sonido o movimiento salvaje para alejar a *" + sujeto;
        }
    }
}
