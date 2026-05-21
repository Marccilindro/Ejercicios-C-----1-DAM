using System;

namespace Ejercicio3
{
    class Program
    {
        static void main(string[] args)
        {
            Pelicula peli;
            Actor persona;
            List<Actor> actores = new List<Actor>();
            string nompeli; int anyoEstreno;
            string nomactor; int anyoNacActor;
            char continuar;
            
            Console.WriteLine("Introducción de datos de película:");
            Console.Write("Nombre: ");  nompeli = Console.ReadLine();
            Console.Write("Año de estreno: "); anyoEstreno= int.Parse(Console.ReadLine());
            Console.WriteLine("\nIntroduce los Actores de la pelicula. ");
            do
            {
                Console.Write("Nombre: ");
                nomactor = Console.ReadLine();
                Console.Write("Año de nacimiento: ");
                anyoNacActor = int.Parse(Console.ReadLine());

                persona = new Actor(nomactor, anyoNacActor);
                actores.Add(persona);
                    
                Console.Write("¿Más actores (S/N)?: ");
                continuar = char.Parse(Console.ReadLine().ToUpper());
            } while (continuar == 'S');

            peli = new Pelicula(nompeli, anyoEstreno, actores);

            // Actores menores de 18 años en el momento del estreno
            List<Actor> menores18 = peli.getActoresMenores18();
            Console.WriteLine("\nActores menores de 18 años en el momento del estreno:");
            foreach (Actor per in menores18)
            {
                per.VerDatosActor();
            }

            Console.ReadLine();

        }
    }
}