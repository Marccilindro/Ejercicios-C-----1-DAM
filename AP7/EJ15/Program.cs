using System;

// EJERCICIO 15. Programa que pida por teclado una contraseña.
// Mientras la contraseña suministrada sea distinta a la palabra “ALDEBARAN” deberá seguir pidiéndola.
// Si se introduce la contraseña correcta el programa deberá informar de ello.
// Deberás controlar que sólo hay 5 intentos para introducir la contraseña.
// Tras agotarlos el programa debe finalizar informando que no se ha suministrado la contraseña correcta.

namespace EJ15
{
    class Program
    {
        static void Main(string[] args)
        {
            int intentos = 0;


            string password;
            do
            {
                intentos++;
                Console.Write("Introduce Contraseña: ");
                password = Console.ReadLine();
            } while (password.ToUpper() != "ALDEBARAN" && intentos < 5);

            if (intentos == 5 && password.ToUpper() != "ALDEBARAN")
                Console.WriteLine("Acceso denegado");
            else
                Console.WriteLine("Bienvenido/a al Sistema");
            Console.ReadKey();
        }
    }
}
