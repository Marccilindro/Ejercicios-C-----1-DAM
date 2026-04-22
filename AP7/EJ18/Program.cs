using System;
using System.Collections.Generic;

namespace EJ18
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int antigüedad;
            int dinero;
            char respuesta;

            do
            {

                Console.Write("Introduce el nombre del empleado: ");
                nombre = Console.ReadLine();

                Console.Write("Introduce la antigüedad del empleado en la empresa: ");
                antigüedad = int.Parse(Console.ReadLine());


                if (antigüedad > 3 && antigüedad < 10)
                {
                    dinero = antigüedad * 100;
                }
                else if (antigüedad >= 10 && antigüedad <= 15)
                {
                    dinero = antigüedad * 115;
                }
                else
                {
                    dinero = antigüedad * 130;
                }

                Console.WriteLine("El empleado " + nombre + " recibe " + dinero + " euros");


                Console.Write("¿Deseas calcular la gratificación de otro empleado (S/N)? ");
                respuesta = char.Parse(Console.ReadLine().ToUpper());


            } while (respuesta == 'S');
        }

    }

}