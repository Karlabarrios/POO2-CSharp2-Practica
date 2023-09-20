using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociación
{
    class Program
    {
        static void Main(string[] args)
        {
            Camioneta c1 = new Camioneta();
            Vehiculo v1 = new Vehiculo();
            v1.Motor.Kilometros = 50;
            c1.Motor.Kilometros = 20;
        }
    }
}
