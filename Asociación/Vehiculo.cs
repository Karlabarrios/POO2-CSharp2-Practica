using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociación
{
    class Vehiculo
    {
        public int Año { get; }
        public string Color { get; }
        public string Marca { get; set; }
        public Motor Motor { get; set; }
        public Carroseria Carroseria { get; }
        public Vehiculo()
        {
            Carroseria = new Carroseria();
        }
        public Vehiculo(int año, string color)
        {
            Año = año;
            Color = color;
            Carroseria = new Carroseria();
        }
        public virtual int Precio()
        {
            return 50000;
        }
    }
}
