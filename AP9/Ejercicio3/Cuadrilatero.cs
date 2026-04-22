using System;

namespace Ejercicio3
{
    /// <summary>
    /// Clase Cuadrilatero
    /// </summary>
    class Cuadrilatero
    {
        // Atributos
        private double lado_a, lado_b;


        /// <summary>
        /// Crea un objeto rectangulo con dos lados
        /// </summary>
        /// <param name="a">lado 1</param>
        /// <param name="b">lado 2</param>
        public Cuadrilatero(double a, double b)
        {
            lado_a = a;
            lado_b = b;
        }

        /// <summary>
        /// Crea un objeto Cuadrado de un lado
        /// </summary>
        /// <param name="a"></param>
        public Cuadrilatero(double a)
        {
            lado_a = a;
            lado_b = a;
        }

        
        /// <summary>
        /// Calcular el perimetro del cuadrilatero
        /// </summary>
        /// <returns>Perimetro</returns>
        public double CalcularPerimetro()
        {
            double superficie = 2 * lado_b + 2 * lado_a;
            return superficie;
        }

        /// <summary>
        /// Calcular el area del cuadrilatero
        /// </summary>
        /// <returns>Area</returns>
        public double CalcularSuperficie()
        {
            double area = lado_b * lado_a;
            return area;
        }


    }
}