using System;

namespace Herencia
{
    class Persona
    {
        protected string nombre;
        protected int edad;

        public string Nombre { set { nombre = value; } }
        public int Edad { set { edad = value; } }

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public virtual void VerDatos()
        {
            Console.WriteLine("Nombre de la persona: " + nombre);
            Console.WriteLine("Edad de la persona: " + edad);
        }
    }
}