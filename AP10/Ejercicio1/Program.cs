using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP10EJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos dos cuentas que se asociarán al cliente
            Cuenta[] cuentas = new Cuenta[2];

            // OJO!. Se puede acceder a las cuentas sin necesidad de pasar por el cliente, ya que no
            // están instanciadas dentro del objeto cliente. Es una agregación. Si el cliente
            // desaparece las cuentas siguen existiendo.

            // Primera cuenta de número 254 y saldo 1000 euros
            cuentas[0] = new Cuenta(254, 1000);
            // Segunda cuenta de número 345 y saldo 750 euros
            cuentas[1] = new Cuenta(345, 750);

            // Creamos el cliente con las dos cuentas asociadas.
            Cliente c1 = new Cliente("Juan", "Marqués", "76885496T", cuentas);

            // Consulta del saldo de las dos cuentas del cliente.
            Console.WriteLine("\nCliente: {0} {1}", c1.getNombre(), c1.getApellido());
            for (int i = 0; i < cuentas.Length; i++)
            {
                Console.WriteLine("Saldo de Cuenta {0}: {1}", i, c1.ConsultarSaldo(i));
            }

            // Ingreso de 5000 euros en primera cuenta
            c1.IngresarDinero(0, 5000);
            // Ingreso de 2500 euros en segunda cuenta
            c1.IngresarDinero(1, 2500);

            // Volvemos a consultar el saldo de las dos cuentas del cliente tras los ingresos.
            Console.WriteLine("\nCliente: {0} {1}", c1.getNombre(), c1.getApellido());
            for (int i = 0; i < cuentas.Length; i++)
            {
                Console.WriteLine("Saldo de Cuenta {0}: {1}", i, c1.ConsultarSaldo(i));
            }

            Console.ReadKey();
        }
    }
}