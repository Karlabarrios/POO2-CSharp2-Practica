using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Animal : SeresVivos
    {
        public virtual string Atacar()
        {
            return "*Lo ataca sin intencion especifica*";
        }
        public virtual string Atacar(string sujeto)
        {
            return "*Ataca salvajemente a " + sujeto + " *";
        }
    }
}
