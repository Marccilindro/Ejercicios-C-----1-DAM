using System;
using System.Reflection.Metadata;

namespace Herencia
{
    class Empleado : Persona
    {
        private float sueldo;

        public float Sueldo { set { sueldo = value; } }

        public Empleado(string nombre, int edad, float sueldo): base(nombre, edad)
        {
            this.sueldo = sueldo;
        }


        public override void VerDatos()
        {
            Console.WriteLine("Nombre del empleado: " + nombre);
            Console.WriteLine("Edad del empleado: " + edad);
            Console.WriteLine("Sueldo del empleado: " + sueldo);
        }
    }
}