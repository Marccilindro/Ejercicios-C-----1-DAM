using System;
using System.Collections.Generic;


namespace EjercicioPractico02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Creamos una instancia per1 de la clase (un objeto)
            // Utilizamos el primer constructor implementado

            Persona per1 = new Persona("Marco", 18);
            per1.VerInfo();

            Console.ReadKey();

            // Creamos una instancia per2 de la clase (un objeto)
            // Utilizamos el segundo constructor implementado

            Persona per2 = new Persona("Ana", 39, true);
            per2.VerInfo();

            Console.ReadKey();

            // Creamos una instancia per3 de la clase (un objeto)
            // Utilizamos el tercer constructor implementado

            Persona per3 = new Persona();
            per3.VerInfo();

            Console.ReadKey();

            Plantilla plantilla = new Plantilla();
            plantilla.Add(per1);
            plantilla.Add(per2);
            plantilla.Add(per3);

            double promedio = plantilla.CalcularPromedio();
            Console.WriteLine("Promedio de edad: {0}", promedio);

            Console.ReadKey();


            /*  double promedio = 0;
              List<Persona> plantilla = new List<Persona>() { per1, per2, per3 };
              foreach (Persona per in plantilla)
              {
                  promedio += per.Edad;
              }
              promedio = promedio / plantilla.Count;
              Console.WriteLine("\nPromedio de edad: {0,N}", promedio);*/

        }
    }
}