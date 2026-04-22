
using System;
using System.Collections.Generic;

namespace Ejecucion_Cola
{
    class Program
    {

        static Boolean esPar(int numero)
        {
            return (numero % 2 == 0);
        }


        static void Main(string[] args)
        {
            Queue<int> cola = new Queue<int>(); //Cola de numeros enteros
            Lista<int> numPares = new Lista<int>(); //cola para almacenar los numeros pares de la lista
            int[] posiciones = new int[5]; //Guardar posciciones de los 500

            int i = 0; int valor = int.MinValue;
            Random rnd = new Random();
            int veces500 = 0;

            do
            {
                i++;
                valor = rnd.Next(1000);
                if (valor == 500)
                {
                    posiciones[veces500] = i;
                    veces500++;
                }
                Console.Write("{0,5}", valor.ToString().PadLeft(4, '0'));
                cola.Enqueue(valor);
                if (esPar(valor)) numPares.Add(valor);
            } while (veces500 != 500);

            Console.WriteLine($"\n\nNúmero de valores: {cola.Count}\n");
            Console.ReadKey();

            while (cola.Count != 0)
            {
                Console.Write("{0,5}", cola.Dequeue().ToString().PadLeft(4, '0'));
            }
            Console.WriteLine($"\n\nNúmero de valores: {cola.Count}\n");


            Console.WriteLine("^Posiciones de los 500's: ");
            for (int j = 0; j < posiciones.Length; j++)
            {
                Console.Write("{0,5}", posiciones[j]);
            }

            Console.ReadKey();

            //Visualizar los numeros pares en la lista
            Console.WriteLine("\nNumeros pares: ");
            foreach (int elem in numPares)
            {
                Console.Write("{0,5}", elem);
            }

            Console.ReadKey();
        }
    }
}
