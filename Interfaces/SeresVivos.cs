using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class SeresVivos
    {
        public string Forma { get; }
        public int Edad { get; }
        public virtual string Comunicarse()
        {
            return "*hace un sonido o movimiento*";
        }
        public virtual string Comunicarse(string sujeto)
        {
            return "*hace un sonido o movimiento*";
        }

        public virtual string Crecer()
        {
            return "*Crece*";
        }

        public virtual string Morir()
        {
            return "*Deja de vivir*";
        }

    }
}
