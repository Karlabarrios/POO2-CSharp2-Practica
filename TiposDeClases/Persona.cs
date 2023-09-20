using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeClases
{
    abstract class Persona
    {
        public string Puesto { get; set; }
        public int Salario { get; }
        public string Referencia { get; }
        public Persona()
        {
        }
        public Persona(string puesto, string referencia)
        {
            Puesto = puesto;
            Referencia = referencia;
            Salario = 1000;
        }
    }
}
