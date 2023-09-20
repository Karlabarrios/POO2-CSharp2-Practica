using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones1
{
    class Program
    {
        static void Main(string[] args)
        {
            Paloma p1 = new Paloma();
            Paloma p2 = new Paloma();
            Paloma p3 = new Paloma();
            Paloma p4 = new Paloma();
            Paloma p5 = new Paloma();

            p1.Color = "Blanca";
            p2.Color = "Gris";
            p3.Color = "Café";
            p4.Color = "Negra";
            p5.Color = "Gris";

            List<Paloma> ColeccionPalomas = new List<Paloma>();
            ColeccionPalomas.Add(p1);
            ColeccionPalomas.Add(p2);
            ColeccionPalomas.Add(p3);
            ColeccionPalomas.Add(p4);
            ColeccionPalomas.Add(p5);

            //Console.WriteLine("El color de la paloma 1 es: " + ColeccionPalomas[0].Color);
            //Console.WriteLine("El color de la paloma 2 es: " + ColeccionPalomas[1].Color);
            //Console.WriteLine("El color de la paloma 3 es: " + ColeccionPalomas[2].Color);
            //Console.WriteLine("El color de la paloma 4 es: " + ColeccionPalomas[3].Color);
            //Console.WriteLine("El color de la paloma 5 es: " + ColeccionPalomas[4].Color);
            //p5.Color = "Manchado";
            //ColeccionPalomas[4].Color = "Gris con manchas";
            //Console.WriteLine("El color de la paloma 5 es: " + ColeccionPalomas[4].Color);
            foreach (Paloma paloma in ColeccionPalomas)
            {
                Console.WriteLine("El color de la paloma es: " + paloma.Color);
            }
            Console.WriteLine("La cantidad de palomas es de: " + ColeccionPalomas.Count);

            Console.ReadKey();
        }
    }
}
