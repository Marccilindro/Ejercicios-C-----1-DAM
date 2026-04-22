using System;

// EJERCICIO 14. Programa que permita mostrar la suma de los números impares comprendidos 
// entre dos valores numéricos positivos introducidos por teclado.

namespace EJ14
{
    class Program
    {

        static bool EsImpar(int num)
        {
            return (num % 2 == 1);
        }

        static void Main(string[] args)
        {
            int inferior, superior;
            long total = 0;

            Console.Write("Introduce límite inferior: ");
            inferior = int.Parse(Console.ReadLine());
            Console.Write("Introduce límite superior: ");
            superior = int.Parse(Console.ReadLine());

            // Valido si los números estan en orden ascendente.
            // En caso contrario los cambio (intercambio de variables).
            if (inferior > superior)
            {
                int aux = inferior;
                inferior = superior;
                superior = aux;
            }

            // Recorro desde inferior hasta superior.
            for(int numero=inferior;numero<=superior;numero++)
            {
                if (EsImpar(numero))
                {
                    total += numero;
                }
            }

            Console.WriteLine("La suma de números impares entre {0} y {1} (ambos incluidos) " +
                "es {2}", inferior, superior, total);
            Console.ReadKey();

        }
    }
}
