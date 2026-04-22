using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado_a = 10;
            double lado_b = 25;

            // Primer cuadrilatero
            Cuadrilatero c1 = new Cuadrilatero(lado_a, lado_b);
            Console.WriteLine("\n--- Datos del primer cuadrilatero---");
            Console.WriteLine("Rectangulo de lados: {0} y {1}:", lado_a, lado_b);
            Console.WriteLine("La superfice es: {0}", c1.CalcularSuperficie());
            Console.WriteLine("EL perimetro es: {0}", c1.CalcularPerimetro());
            Console.ReadKey();

            // Segundo cuadrilatero
            Cuadrilatero c2 = new Cuadrilatero(lado_a);
            Console.WriteLine("\n--- Datos del segundo cuadrilatero---");
            Console.WriteLine("Cuadradro de lado: {0}:", lado_a);
            Console.WriteLine("La superfice es: {0}", c2.CalcularSuperficie());
            Console.WriteLine("EL perimetro es: {0}", c2.CalcularPerimetro());
            Console.ReadKey();
        }
    }
}