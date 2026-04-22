using System;

namespace Atribstatic
{
    class Empleado
    {
        // Atributos 

        private string nombre;                      // nombre de empleado
        private string apellido;                    // apellido del empleado
        private int edad;                           // edad del empleado
        private static double salarioBase = 890;    // salario base del empleado (atributo static -ámbito de clase-
                                                    // Cuando creamos un objeto el salarioBase es de 890.                                                     //    el salarioBase afectara a todas los objetos.
                                                    // Si cambiamos el salario base afectará a todos los objetos de la clase.


        // Propiedades para acceso a atributos
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public int Edad { get { return Edad; } set { edad = value; } }
        public double SalarioBase { get { return salarioBase; } set { salarioBase = value; } }

        // método de acceso de escritura al atributo salarioBase (es complementario a la propiedad Salario)
        // Es un método estático para poder ser llamado desde la Clase Empleado (directamente).
        // Cuando se asigna un salario base se cambia para todos los empleados que se hayan instanciado de la clase.
        public static void setSalarioBase(double sbase)
        {
            salarioBase = sbase;
        }

        // Constructores
        public Empleado(string pnom, string papell, int pedad)
        {
            this.nombre = pnom;
            this.apellido = papell;
            this.edad = pedad;
        }

        public Empleado()
        {
            Console.Write("\nNombre del empleado: ");
            this.nombre = Console.ReadLine();
            Console.Write("Apellido del empleado: ");
            this.apellido = Console.ReadLine();
            Console.Write("Edad del empleado: ");
            this.edad = int.Parse(Console.ReadLine());
        }

        // métodos publicos

        // Suma un plus al salario base y devuelve el nuevo salarioBase.
        // Hacemos el Método estático de tal forma que no sea necesario instaciar 
        // un objeto para incrementar el salario base de todos los empleados.
        public static double AumentoPlus(double sueldoPlus)
        {
            salarioBase += sueldoPlus;
            return salarioBase;
        }

        public void VerDatosEmpleado()
        {
            Console.Write("\nEmpleado: {0} {1}", nombre, apellido);
            Console.Write("\nEdad: {0} años.", edad);
            Console.Write("\nSalario base: {0:N} euros", salarioBase);
            Console.ReadKey();
        }


    }
}