using System;
using System.Collections.Generic;
namespace SaltoDeLongitud
{
    class SaltadorDeLongitud
    {
        // Atributos privados
        private string nombre;
        private int edad;
        private double altura;
        private int maxSaltos;
        private List<double> marcas;
        // Constructor con parámetros
        public SaltadorDeLongitud(string nombre, int edad, double altura, int
        maxSaltos)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.altura = altura;
            this.maxSaltos = maxSaltos;
            this.marcas = new List<double>();
        }
        // Constructor sobrecargado que pide información por teclado
        public SaltadorDeLongitud()
        {
            Console.Write("\nINTRODUCCIÓN DE INFORMACIÓN DE saltador: ");
            Console.Write("========================================\n");
            Console.Write("Ingrese el nombre del saltador: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese la edad del saltador: ");
            edad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura del saltador en metros: ");
            altura = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el número máximo de saltos: ");
            maxSaltos = int.Parse(Console.ReadLine());
            marcas = new List<double>();
        }
        // Propiedades de acceso para nombre, edad y altura (solo get)
        public string Nombre { get { return nombre.ToUpper(); } }
        public int Edad { get { return edad; } }
        public double Altura { get { return altura; } }
        // Métodos de acceso tipo getters y setters para maxSaltos
        public int getMaxSaltos()
        {
            return maxSaltos;
        }
        public void setMaxSaltos(int value)
        {
            maxSaltos = value;
        }

        // Método para mostrar la información del saltador
        public void MostrarInformacion()
        {
            Console.WriteLine("\nINFORMACIÓN DE SALTADOR:");
            Console.WriteLine("\tNombre: {0}", nombre);
            Console.WriteLine("\tEdad: {0}", edad);
            Console.WriteLine("\tAltura: {0} metros", altura);
            Console.WriteLine("\tMáximo de Saltos: {0} saltos", maxSaltos);
            if (marcas.Count > 0)
            {
                Console.Write("\tMarcas obtenidas:\t");
                foreach (double valor in marcas)
                {
                    Console.Write("{0,10}", valor);
                }
                Console.WriteLine();
                // Otra opción en vez de usar la repetitiva foreach
                // Console.WriteLine("Marcas: " + string.Join(", ", marcas));
            }
            else
            {
                Console.WriteLine("\tNo ha realizado ningún salto. No dispone de marcas");
            }
        }
        // Método para agregar una nueva marca
        public void AgregarMarca(double nuevaMarca)
        {
            if (marcas.Count == maxSaltos)
            {
                Console.WriteLine("Máximo de saltos ya realizados");
                Console.WriteLine("No se pueden añadir más marcas");
            }
            else
            {
                marcas.Add(nuevaMarca);
                Console.WriteLine("\nSaltador: {0} --> Marca añadida: {1} metros", nombre, nuevaMarca);
            }
        }
        // Método para obtener la mejor marca
        public double ObtenerMejorMarca()
        {
            double mejorMarca = 0;
            if (marcas.Count > 0)
            {
                foreach (double marca in marcas)
                {
                    if (marca > mejorMarca)
                    {
                        mejorMarca = marca;
                    }
                }
                return mejorMarca;

            }
            return -1;
        }
        // Método para obtener el promedio de las marcas
        public double ObtenerPromedioMarcas()
        {
            double suma = 0;
            if (marcas.Count > 0)
            {
                foreach (double marca in marcas)
                {
                    suma += marca;
                }
                return suma / marcas.Count;
            }
            return 0;
        }
    }
}