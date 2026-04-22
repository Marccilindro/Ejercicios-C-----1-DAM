using System;

// EJERCICIO 10. Programa que muestre los términos de la siguiente serie(1, 3, 7, 15, 31, …) que sean menores de 1000.

namespace EJ10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            const int limite = 1000;
            do
            {
                Console.Write("{0,5}", numero);
                numero = numero * 2 + 1;
            } while (numero < limite);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
