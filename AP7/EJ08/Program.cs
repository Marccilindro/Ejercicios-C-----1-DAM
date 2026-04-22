using System;

// EJERCICIO 08. Elabora un programa que solicite dos números y muestre su producto por el método de las sumas sucesivas.
// Por ejemplo: 5 x 4 = 20  es 5 + 5 + 5 + 5 = 20 (sumamos 4 veces el número 5)

namespace EJ08
{
    class Program
    {
        static void Main(string[] args)
        {
            int mando, mador;
            long producto = 0;

            Console.Write("Introduce el multiplicando: ");
            mando = int.Parse(Console.ReadLine());
            Console.Write("Introduce el multiplicador: ");
            mador = int.Parse(Console.ReadLine());

            for (int i = 0; i < mador; i++)
                producto += mando;

            Console.WriteLine("{0} x {1} = {2}", mando, mador, producto);
            Console.ReadKey();
        }
    }
}
