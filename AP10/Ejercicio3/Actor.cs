using System;
using System.Security.AccessControl;

namespace Ejercicio3
{
    class Actor
    {
        private string nombre;
        private int anyoNac;

        public Actor(string n, int an)
        {
            this.nombre = n;
            this.anyoNac = an;
        }

        public int getAnyoNacimiento()
        {
            return anyoNac;
        }

        public void VerDatosActor()
        {
            Console.WriteLine("Nombre: ", nombre);
            Console.WriteLine("Anyo de nacimiento", anyoNac);
        }
        
    }
}