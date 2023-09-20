using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class AnimalesDomesticos : Animal
    {
        public string Nombre { get; set; }
        public override string Atacar()
        {
            return "*Lo ataca jugando, con cuidado*";
        }
        public override string Atacar(string sujeto)
        {
            return "*Ataca jugando a " + sujeto + " *";
        }
        public override string Comunicarse()
        {
            return "*hace un sonido o movimiento de convivencia*";
        }
        public override string Comunicarse(string sujeto)
        {
            return "*hace un sonido o movimiento para interactuar con *" + sujeto;
        }
    }
}
