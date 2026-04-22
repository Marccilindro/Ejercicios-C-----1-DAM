using System;


namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Primer triangulo
            Triangulo t1 = new Triangulo(10, 10, 30);
            t1.CalculaTipoTriangulo();
            Console.ReadKey();


            // Segundo triangulo
            Triangulo t2 = new Triangulo();
            t2.CalculaTipoTriangulo();
            Console.ReadKey();

        }
    }
}