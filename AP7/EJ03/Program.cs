using System;

// EJERCICIO 03. Programa que permita calcular el número de CDs necesarios para hacer 
// una copia de seguridad de la información almacenada en un HD cuya capacidad se 
// conoce(deberás pedirla por teclado). 
// Considera que el disco duro está lleno de información y su capacidad expresada en GigaBytes.
// Un CD virgen tiene 700 Megabytes de capacidad y un Gigabyte es igual a 1.024 megabytes.

namespace EJ03
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacidad;
            int numCDs = 0;
            const int capCD = 700;

            Console.Write("Indica la capacidad del HD (en Gb): ");
            capacidad = Convert.ToDouble(Console.ReadLine());
            // Pasamos la capacidad en Gb a Mb
            capacidad *= 1024;
            numCDs = Convert.ToInt16(Math.Truncate(capacidad/capCD)+1);
            // numCDs = (int) Math.Truncate(capacidad/capCD)+1;
            Console.Write("El número de unidades a utilizar para el backup son {0} CDs",numCDs);
            Console.ReadLine();
        }
    }
}
