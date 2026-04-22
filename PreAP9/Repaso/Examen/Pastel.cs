using System;
using System.Collections.Generic;

namespace Examen
{
    class Pastel
    {
        // Atributos de la clase Pastel
        private static int contadorID = 100;
        private int id;
        private string nombre;
        private double precioVenta;
        private double costeProduccion;
        private double peso;
        private int calorias;
        private List<string> ingredientes;


        // Primer constructor que pide los datos por teclado
        public Pastel()
        {
            this.id = contadorID++;

            Console.WriteLine("Introduce el nombre del pastel: ");
            this.nombre = Console.ReadLine().ToUpper();
            do
            {
                Console.WriteLine("Introduce el precio de venta del pastel");
                this.precioVenta = Convert.ToDouble(Console.ReadLine());
            } while (this.precioVenta <= 0);

            do
            {
                Console.WriteLine("Introduce el coste de produccion del pastel");
                this.costeProduccion = Convert.ToDouble(Console.ReadLine());
            } while (this.costeProduccion <= 0);

            do
            {
                Console.WriteLine("Introduce el peso del pastel");
                this.peso = Convert.ToDouble(Console.ReadLine());
            } while (this.peso <= 0);

            do
            {
                Console.WriteLine("Introduce el numero de calorias del pastel");
                this.calorias = Convert.ToInt32(Console.ReadLine());
            } while (this.calorias <= 0);

            this.ingredientes = new List<string>();
            string ingrediente;

            do
            {
                Console.WriteLine("Introduce un ingrediente (deja vacio para terminar)");
                ingrediente = Console.ReadLine();

                if (ingrediente != "")
                {
                    this.ingredientes.Add(ingrediente);
                }

            } while (ingrediente != "");
        }

        // Constructor al que le pasamos los datos por parametros
        public Pastel(string nombre, double precioVenta, double costeProduccion, double peso, int calorias)
        {
            this.id = contadorID++;
            this.nombre = nombre;
            this.precioVenta = precioVenta;
            this.costeProduccion = costeProduccion;
            this.peso = peso;
            this.calorias = calorias;
            this.ingredientes = new List<string>();
        }


        // Propiedades con acceso de lectura
        public int Id { get { return id; } }
        public string Nombre { get { return nombre; } }
        public double PrecioVenta { get { return precioVenta; } }
        public double CosteProduccion { get { return costeProduccion; } }
        public double getPeso()
        {
            return peso;
        }
        public int getCalorias()
        {
            return calorias;
        }

        // Metodo para añadir ingredientes a la lista, comprueba previamente si existe
        public int AñadirIngrediente(string ingrediente)
        {
            bool esta = false;
            foreach (string s in ingredientes)
            {
                if (s == ingrediente.ToUpper())
                {
                    esta = true;
                }

                if (!esta)
                {
                    ingredientes.Add(ingrediente.ToUpper());
                }
                return ingredientes.Count;
            }
        }

        // Calculo del margen de beneficio de la venta del pastel
        public double GananciaPastel()
        {
            // Queremos que el precio de venta sea mayor que el coste de produccion
            if (this.precioVenta > this.costeProduccion)
            {
                return this.precioVenta - this.costeProduccion;
            }
            else
            {
                return 0;
            }
        }

        // Nombre de todos los ingredientes del pastel
        public string ObtenerIngredientes()
        {
            string ingre = "";
            for (int i = 0; i < ingredientes.Count; i++)
            {
                ingre += ingredientes[i] + "/";
            }
            return ingre;
        }

        // Clasificacion calorica del pastel
        public char ClasificacionCalorica()
        {
            if (this.calorias < 100) return 'A';
            else if (this.calorias <= 250) return 'B';
            else if (this.calorias <= 500) return 'C';
            else return 'D';
        }

        // Mosntrar informacion del pastel
        public void MonstrarInformacion()
        {
            Console.WriteLine("ID del pastel: {0}", id);
            Console.WriteLine("Nombre del pastel: {0}", nombre);
            Console.WriteLine("Precio de venta: {0}", precioVenta);
            Console.WriteLine("Coste de produccion: {0}", costeProduccion);
            Console.WriteLine("Peso del pastel: {0}", peso);
            Console.WriteLine("Calorias del pastel: {0}", calorias);
            Console.WriteLine("Numero de ingredientes: {0}", ingredientes.Count);
        }

    }
}