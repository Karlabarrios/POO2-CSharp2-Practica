using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Italiano : Humano
    {
        public override string Comunicarse()
        {
            return "Bonjourno";
        }
        public override string Comunicarse(string sujeto)
        {
            return "Bonjourno " + sujeto;
        }
    }
}
