using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeClases
{
    sealed class Lider : Persona
    {
        public string Nombre { get; set; }
        public int DeberUno()
        {
            int SalarioPropio = Salario + 500;
            return SalarioPropio;
        }
    }
}
