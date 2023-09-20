using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Mascota
    {
        public string Nombre { get; set; }
        public string Color { get; set; }
        public int Edad { get; set; }

        public Mascota(string color, int edad)
        {
            Color = color;
            Edad = edad;
        }
        public Mascota()
        {
        }
        public string Saludar()
        {
            return "*Da la pata*";
        }
        public string Saludar(string a)
        {
            if (a.Contains("hamster"))
                return "snif";
            else if (a.Contains("gato"))
                return "Miau";
            else if (a.Contains("perro"))
                return "Bark";
            else
                return "*Procede a dar la pata*";
        }
    }
}
