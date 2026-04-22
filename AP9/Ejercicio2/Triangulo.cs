using System;

namespace Ejericio2
{
    class Triangulo
    {
        //Atributos de la clase 
        double lado1, lado2, lado3;

        // Primer Constructor: Con petición de datos por teclado
        public Triangulo()
        {
            Console.WriteLine("Datos del triangulo: ");
            Console.WriteLine("=====================");

            Console.Write("Introduce el Lado 1: ");
            lado1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce el Lado 2: ");
            lado2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce el Lado 3: ");
            lado3 = Convert.ToDouble(Console.ReadLine());
        }


        // Segundo Constructor
        public Triangulo(double l1, double l2, double l3)
        {

            lado1 = l1;
            lado2 = l2;
            lado3 = l3;
        }

        public bool EsEquilatero()  // Todos los lados iguales
        {
            if (lado1 == lado2 && lado2 == lado3) return true;
            else return false;

        }

        public bool EsEscaleno() // Todos los lados distintos
        {
            if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3) return true;
            else return false;

        }

        public bool EsIsosceles() // Dos lados iguales y uno diferente
        {
            if (EsEquilatero() || EsEscaleno()) return false;
            else return true;

        }

        // Metodo adicional (no lo pide el ejercicio)
        public string CalculaTipoTriangulo()
        {
            if (EsEquilatero()) return "El triangulo es Equilátero";
            if (EsEscaleno()) return "El triangulo es Escaleno";
            return "El triangulo es Isósceles";
        }
    }
}