using System;
using System.Collections.Generic;

namespace Atribstatic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos una lista de 3 empleados. Salario base por defecto es 890.
            List<Empleado> listaEmpleado = new List<Empleado>();
            for (int i = 0; i < 3; i++)
            {
                listaEmpleado.Add(new Empleado());
            }
            // Visualizamos el salario base de cada empleado
            foreach (Empleado emp in listaEmpleado)
            {
                Console.WriteLine("El salario base de {0} es {1}", emp.Nombre, emp.SalarioBase);
            }
            // Modifico el salario base de un empleado... 
            // Al ser un atributo static (ámbito de clase) lo modifico para todos los objetos de la clase (utilizo su propiedad).
            listaEmpleado[0].SalarioBase = 1200;
            
            // Para acceder a un método o atributo estático (también depende de su visibilidad), 
            // no es necesario crear un objeto, para ello escribimos nombre_clase.metodo_estatico(parámetros);
            // Piensa, por ejemplo cómo accedemos al método WriteLine de la Clase Console... Efectivamente WriteLine es método static
            // En nuestro ejemplo podríamos hacer: 
            Empleado.setSalarioBase(1400);   // el método SetSalarioBase lo hemos definido como static.

            Console.WriteLine("\nNuevo salario Base: {0}", listaEmpleado[0].SalarioBase);

            // Vuelvo a visualizar el salario base de cada empleado y podemos ver que todos los empleados tienen el mismo
            // salario base (ha cambiado para todos).
            foreach (Empleado emp in listaEmpleado)
            {
                emp.VerDatosEmpleado();
            }

            // Aumento en una cantidad (pedida por teclado) el salarioBase de los empleados.
            Console.Write("\nVamos a aumentar el Salario Base de los empleados. Indica la cantidad a incrementar: ");
            double cantAumento = double.Parse(Console.ReadLine());
            // Invoco al método AumentoPlus utilizando la clase Empleado (y no un objeto). No utilizo el retorno: nuevo salarioBase
            Empleado.AumentoPlus(cantAumento);

            // Vuelvo a visualizar el salario base de cada empleado y podemos ver que todos los empleados tienen el mismo
            // salario base (ha cambiado para todos).
            foreach (Empleado emp in listaEmpleado)
            {
                emp.VerDatosEmpleado();
            }

            Console.ReadKey();
        }
    }
}