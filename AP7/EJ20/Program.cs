using System;

namespace EJ20
{
    class Program
    {
        static void Main(string[] args)
        {
            int precio;
            int iva;
            int resultado;

            do
            {
                Console.Write("Dime el precio del producto (0 para salir): ");
                precio = int.Parse(Console.ReadLine());

                if (precio == 0)
                {
                    break;
                }

                do
                {
                    Console.Write("Dime el tipo de IVA (16 - 21): ");
                    iva = int.Parse(Console.ReadLine());

                    if (iva < 16 || iva > 21)
                    {
                        Console.WriteLine("Introduce un IVA correcto");
                    }

                } while (iva < 16 || iva > 21);

                resultado = precio + (precio * iva / 100);

                Console.WriteLine("Precio sin IVA: " + precio + " euros");
                Console.WriteLine("Precio con IVA: " + resultado + " euros");

            } while (precio != 0);
        }
    }
}
