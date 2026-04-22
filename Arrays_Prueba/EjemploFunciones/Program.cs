using System;

namespace EjemploFunciones
{
    class Program
    {
        static void visualizaSuma(int a, int b)
        {
            Console.WriteLine(a + " y " + b + " suman " + (a + b));
        }

        static int calculaSuma(int a, int b)
        {
            int resultado = a + b;
            return resultado;
        }

        static void Main(string[] args)
        {
            int valor1, valor2;

            Console.Write("Dame el primer valor:");
            valor1 = int.Parse(Console.ReadLine());
            Console.Write("Dame el segundo valor:");
            valor2 = Convert.ToInt16(Console.ReadLine());

            visualizaSuma(valor1, valor2);
        }
    }
}