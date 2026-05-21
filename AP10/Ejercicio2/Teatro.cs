using System;
using System.Runtime.InteropServices;

namespace Ejercicio2
{
    class Teatro
    {
        private string nombre;
        private string direccion;
        Funcion[] funciones = new Funcion[4];

        public Teatro(string dire, string nom, string[] nombres, double[] precios)
        {
            this.nombre = nom;
            this.direccion = dire;

            for (int i = 0; i < funciones.Length; i++)
            {
                funciones[i] = new Funcion(nombres[i], precios[i]);
            }
        }

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }


        public void ActualizarNombreFuncion(int nfun, string nombre)
        {
            funciones[nfun].setNombre(nombre);
        }

        public void ActualizarPrecioFuncion(int nfun, double precio)
        {
            funciones[nfun].setPrecio(precio);
        }

        public string DevuelveNombreFuncion(int nfum)
        {
            return funciones[nfum].getNombre;
        }

        public string DevuelvePrecioFuncion(int nfum)
        {
            return funciones[nfum].getPrecio;
        }
    }
}