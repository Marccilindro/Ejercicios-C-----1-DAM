using System;

// EJERCICIO 13. Programa que permita obtener una combinación de lotería primitiva (6 números entre 1 y 49).
// Para generar los números de forma aleatoria puedes utilizar la clase Random del namespace System.

namespace EJ13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Utilizo un objeto de la clase Random. 
            // Con su método Next podremos generar los número aleatorios entre 1 y 49. 
            Random aleatorio = new Random();

            // Array de 6 elementos enteros para almacenar la combinación
            int[] combinacion = new int[6];

            Console.WriteLine("Combinación de lotería primitiva:\n");
            for (int i=0;i<6;i++)
            {
                combinacion[i] = aleatorio.Next(1, 50); //al hacer el aleatorio.Next no pillaba el 49 asi que al poner 50 si que lo pilla
                Console.Write("{0,5}", combinacion[i]);
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
