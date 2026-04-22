using System;

// EJERCICIO 04. Programa que calcula el mayor de tres números proporcionados por teclado.
// Previamente a ello debe comprobar que los tres números suministrados son distintos.
// En caso de que no lo sea debe avisar que los números suministrados no son válidos.

namespace EJ04
{
    class Program
    {

        // función que calcula y devuelve el mayor de los tres números.
        static int CalculaMayor(int[] num)
        {
            int mayor = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > mayor)
                    mayor = num[i];
            }
            return mayor;
        }
        
        // función que comprueba si existen números iguales en la entrada
        static bool SonIguales(int[] num)
        {
            return (num[0] == num[1] || num[0] == num[2] || num[1] == num[2]);
        }


        static void Main(string[] args)
        {
            
            // Utilizo un array para cargar los números
            int[] numeros = new int[3];
            // Carga de Valores (los tres números)
            for(int i=0;i<3;i++)
            {
                Console.Write("Dame el número {0}: ", i);
                numeros[i] = int.Parse(Console.ReadLine());
            }
            // Comprobación de que no son iguales
            if (SonIguales(numeros))
                  Console.WriteLine("Existe números iguales. Datos no válidos");
            else // Cálculo y visualización del mayor
                Console.WriteLine("El mayor es {0}", CalculaMayor(numeros));
            Console.ReadKey();   
        }
    }
}
