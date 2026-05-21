using System;

namespace Ejericio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Como valor añadido del ejercicio se realiza un programa principal que
            // hace uso de las clases teatro y funcion.
            Console.Write("Nombre del teatro: ");
            string nombreTeatro = Console.ReadLine();
            Console.Write("Dirección del teatro: ");
            string dirTeatro = Console.ReadLine();

            string[] nombrefunciones = new string[4];
            double[] preciofunciones = new double[4];
            Console.WriteLine("Indica nombre y precio de cada función");
            for (int i = 0; i < nombrefunciones.Length; i++)
            {
                Console.Write("Nombre de funcion {0}: ", i + 1);
                nombrefunciones[i] = Console.ReadLine();
                Console.Write("Precio de funcion {0}: ", i + 1);
                preciofunciones[i] = double.Parse(Console.ReadLine());
            }

            Teatro principal = new Teatro(nombreTeatro, dirTeatro, nombrefunciones, preciofunciones);

            // Ejemplo de utilización de metodos de objetos Teatro y Funcion.
            Console.WriteLine();

            // Acceso al nombre y dirección del teatro
            Console.WriteLine("Teatro: {0}  Dirección: {1}", principal.getNombre(), principal.getDireccion());
            // Acceso al nombre y precio de la 1ª funcion del teatro
            Console.WriteLine("Funcion: {0}  Precio: {1}",
                principal.DevuelveNombreFuncion(0), principal.DevuelvePrecioFuncion(0));
            // Modificacion del nombre de la última función
            principal.ActualizarNombreFuncion(3, "El lado oscuro");
            // Incremento del precio de las cuatro funciones en un 25%.
            for (int i = 0; i < 4; i++)
            {
                principal.ActualizarPrecioFuncion(i, principal.DevuelvePrecioFuncion(i) * 1.25);
            }
            // Acceso al nombre y precio de la 2ª funcion del teatro
            Console.WriteLine("Funcion: {0}  Precio: {1}",
                principal.DevuelveNombreFuncion(1), principal.DevuelvePrecioFuncion(1));

            Console.ReadKey();
        }
    }
}