using System;
using System.Collections.Generic;

namespace Ej16
{
    class Program
    {

        static void Main(string[] args)
        {

            List<float> temperaturas = new List<float>();
            float temperatura;
            float tempMinima = float.MaxValue;
            float tempMaxima = float.MinValue;

            do
            {
                Console.Write("Indica la temperatura (99 para finalizar):");
                temperatura = Convert.ToSingle(Console.ReadLine());

                if (temperatura != 99)
                {
                    temperaturas.Add(temperatura);
                    if (temperatura > tempMaxima) tempMaxima = temperatura;
                    if (temperatura < tempMinima) tempMinima = temperatura;
                }

            } while (temperatura != 99);

            Console.WriteLine("La cantidad de temperaturas es {0}", temperaturas.Count());
            Console.WriteLine("Temperatura maxima: {0} --- Temperatura minima: {1}", tempMaxima,tempMinima);
            Console.ReadKey();

        }
    }
}