using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreEscrituraMasHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Gato gato1 = new Gato();
            gato1.Nombre = "Copo";
            Perro perro1 = new Perro();
            perro1.Nombre = "Bola";
            Oso oso1 = new Oso();
            Tigre tigre1 = new Tigre();

            Console.WriteLine("El gato " + gato1.Nombre + " dice: " + gato1.Comunicarse());
            Console.WriteLine("El perro dice: " + perro1.Comunicarse());
            Console.WriteLine("El oso hace: " + oso1.Comunicarse());
            Console.WriteLine(" ");
            Console.WriteLine("Gato " + gato1.Atacar());
            Console.WriteLine("Perro " + perro1.Atacar());
            Console.WriteLine("Oso " + oso1.Atacar());
            Console.WriteLine("Tigre " + tigre1.Atacar());
            Console.WriteLine(" ");

            Animal a1 = gato1;
            Gato g8 = (Gato)a1;
            gato1.Nombre = "Copo de nieve";
            Console.WriteLine("Gato " + a1.Atacar());
            Console.WriteLine("El gato " + g8.Nombre + " dice: " + g8.Comunicarse());

            Console.ReadKey();
        }
    }
}
