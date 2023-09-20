using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Aguila : AnimalesSalvajes, Flyable
    {
        public string Aletear()
        {
            return "*Aletea para manifestar algo*";
        }

        public string Planear()
        {
            return "*Planea para aterrizar*";
        }
        public string Planear(string objeto)
        {
            return "*Planea para cazar " + objeto + " *";
        }

        public string Volar()
        {
            return "vuela";
        }
    }
}
