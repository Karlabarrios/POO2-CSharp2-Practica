using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Mascota m1 = new Mascota();
            PerroLabrador pL1 = new PerroLabrador();
            Gato g1 = new Gato();
            Hamster h1 = new Hamster();
            Console.WriteLine("El perro saluda así: " + pL1.Saludar("perro"));
            Console.WriteLine("El gato saluda así: " + g1.Saludar("gato"));
            Console.WriteLine("El hamster saluda así: " + h1.Saludar("hamster"));
            Console.WriteLine("El perro saluda así: " + pL1.Saludar("Perro"));
            Console.WriteLine("El hamster saluda así: " + h1.Saludar());
            Console.ReadKey();
        }
    }
}
