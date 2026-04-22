using System;

// EJERCICIO 07. Programa que permita mostrar el sueldo promedio de 5 empleados.
// El programa deberá leer el sueldo de cada empleado en euros y calcular su promedio.
// Realiza una modificación posterior de tal forma que también informe del sueldo máximo introducido.

namespace EJ07
{
    class Program
    {
        private static void CargarSueldos(float[] paga)
        {
            for(int i=0;i<5;i++)
            {
                Console.Write("Sueldo del empleado {0}: ", i+1);
                paga[i] = float.Parse(Console.ReadLine());
            }
        }
       
        static void Main(string[] args)
        {
            float[] sueldo = new float[5];
            float promedio = 0;
            float maxSueldo = float.MinValue;

            // Utilizo una función para cargar el array de sueldos.
            // El array es un puntero y se pasa por Referencia.
            // En todo caso se puede anteponer el modificador REF para explicitarlo.
            CargarSueldos(sueldo);

            for(int i=0;i<sueldo.Length;i++)
            {
                promedio += sueldo[i];
                if (sueldo[i]>maxSueldo) {
                    maxSueldo = sueldo[i];
                }
            }
            promedio /= sueldo.Length;
            Console.WriteLine("El sueldo promedio es de {0:N} euros", promedio);
            Console.WriteLine("El sueldo máximo es {0:N} euros", maxSueldo);
            Console.ReadKey();

        }

      
    }
}
