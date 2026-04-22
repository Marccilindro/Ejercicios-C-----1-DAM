using System;

// EJERCICIO 11. Elabora un programa que pida números por teclado y finalice cuando introduzcamos el número 0.
// Debe informarnos cuantos números se han introducido el total y de ellos cuantos son pares y cuantos impares.

namespace EJ11
{
    class Program
    {
        static bool EsPar(int num)
        {
            return (num % 2 == 0);

        }
        
        // ¡¡¡OJO: Si deseamos guardar los números que se van introduciendo
        // por teclado sería necesario utilizar una colección!!!
        // Como en el ejercicio 16...  
        static void Main(string[] args)
        {
            int numero, pares=0, impares=0;

            do
            {
                Console.Write("Introduce un número: ");
                numero = int.Parse(Console.ReadLine());
                if (numero != 0)
                {
                    if (EsPar(numero))
                        pares++;
                    else
                        impares++;
                }
            } while (numero != 0);

            Console.WriteLine("\nNúmeros totales: {0}", pares + impares);
            Console.WriteLine("Números Pares: {0}", pares);
            Console.WriteLine("Números Impares: {0}", impares);
            Console.ReadKey();
        }
    }
}
