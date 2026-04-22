using System;
using System.Collections.Generic;

namespace EJ17
{
    class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();
            int resultado = num.Next(1, 101);

            int intentos = 0;
            int numero;

            do
            {
                Console.Write("¿Cuál crees que es el número? ");
                numero = int.Parse(Console.ReadLine());
                intentos++;

                if (numero < resultado)
                {
                    Console.WriteLine("El número es mayor");
                }
                else if (numero > resultado)
                {
                    Console.WriteLine("El número es menor");
                }

            } while (numero != resultado);

            Console.WriteLine($"Enhorabuena, has adivinado el número en {intentos} intentos");

        }
    }
}