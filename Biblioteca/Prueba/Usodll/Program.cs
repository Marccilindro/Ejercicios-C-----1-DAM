using System;
using Utilidades;

namespace UsoDll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame un DNI: ");
            string dni = Console.ReadLine().ToUpper();
            Console.WriteLine("El NIF es {0}: ",Utilidades.CalcularLetraNIF(dni));
        
        }
    }
}