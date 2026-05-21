using System;

namespace Ejercicio2
{
    class Funcion
    {
        private string nombre;
        private double precio;

        public Funcion(string nom, double pre)
        {
            this.nombre = nom;
            this.precio = pre;
        }

        // Cambiar Nombre
        public string Nombre { get { return nombre; } set { nombre = value; } }
        
        
        //Cambiar precio
        public double Precio { get { return precio; } set { precio = value; } }
    }
}