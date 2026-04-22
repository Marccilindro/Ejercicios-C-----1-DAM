using System;

//EJERCICIO 05. Programa que, tras pedir la medida de los tres lados de un triángulo
//identifique qué tipo es(escaleno, equilátero o isósceles). 

namespace EJ05
{
    class Program
    {

        static string DimeTipoTriangulo(int l1, int l2, int l3)
        {
            if (l1 != l2 && l1 != l3 && l2 != l3)
                return "escaleno"; 
            else if (l1 == l2 && l1 == l3 && l2 == l3)
                return "equilatero"; 
            else
                return "isósceles"; 
        }

        static void Main(string[] args)
        {

            int lado1, lado2, lado3;
            
            // Petición de Datos
            Console.Write("Indica el lado 1: ");
            lado1 = int.Parse(Console.ReadLine());
            Console.Write("Indica el lado 2: ");
            lado2 = int.Parse(Console.ReadLine());
            Console.Write("Indica el lado 3: ");
            lado3 = int.Parse(Console.ReadLine());

            Console.WriteLine("El triángulo es {0}.", DimeTipoTriangulo(lado1, lado2, lado3));
            Console.ReadKey();
            
        }
               
    }
}
