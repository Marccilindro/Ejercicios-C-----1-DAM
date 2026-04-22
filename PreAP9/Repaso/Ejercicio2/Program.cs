using System;
using System.Collections.Generic;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Serie> listaSeries = new List<Serie>();

            // Crear las series
            listaSeries.Add(new Serie());
            listaSeries.Add(new Serie("Juego de Tronos", "Fantasía", "George R. R. Martin"));
            listaSeries.Add(new Serie("The Walking Dead. El retorno", "Terror", "Robert Kirkman"));

            // Visualizar cada serie
            foreach (Serie s in listaSeries)
            {
                Console.WriteLine("Serie:{0} --- {1}", s.GetTitulo(), s.GetEstrenada());
            }

            // Funciones
            
        }
    }
}