using System;
using System.Collections.Generic;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancio un objeto p1 de la clase Persona que es de tipo persona
            Persona p1 = new Persona(); 
            p1.Nombre = "Marco";
            p1.Edad = 18;
            p1.VerDatos();
            Console.ReadKey();

            // Instancio un objeto p2 de la clase Empleado que es de tipo empleado
            Empleado p2 = new Empleado();
            p2.Nombre = "Juan";
            p2.Edad = 25;
            p2.Sueldo = 1500;
            p2.VerDatos();
            Console.ReadKey();

            // Instancio un objeto p3 de la clase Empleado que es de tipo persona
            Persona p3 = new Empleado();
            p3.Nombre = "Ana";
            p3.Edad = 30;
            p3.VerDatos();
            Console.ReadKey();

            List<Persona> plantilla = new List<Persona>() {p1, p2, p3};
            foreach (Persona p in plantilla)
            {
                p.VerDatos();
            }
            Console.ReadKey();
        }
    }
}