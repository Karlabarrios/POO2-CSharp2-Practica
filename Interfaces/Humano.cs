using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Humano : Animal, Biteable
    {
        public string Nombre { get; }
        public int Curp { get;  }
        public string ApellidoPaterno { get;  }

        public Humano()
        {
        }
        public Humano(string nombre, int curp)
        {
            Nombre = nombre;
            Curp = curp;
            ApellidoPaterno = "Humani";
        }
        public override string Atacar()
        {
            return "*Lo ataca con intensiones psicologicas propias*";
        }
        public override string Atacar(string sujeto)
        {
            return "Te voy a golperar " + sujeto;
        }
        public override string Comunicarse()
        {
            return "Hola";
        }
        public override string Comunicarse(string sujeto)
        {
            return "Hola " + sujeto;
        }

        public string Masticar()
        {
            return "*mastica*";
        }

        public string Morder()
        {
            return "*muerde*";
        }
    }
}
