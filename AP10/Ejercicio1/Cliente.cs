using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP10EJ1
{
    class Cliente
    {
        private string nombre;      // nombre del cliente
        private string apellido;    // apellido del cliente
        private string nif;         // nif del cliente
        private Cuenta[] cuentas;   // Array de cuentas del cliente

        // Constructor
        public Cliente(string nom, string ape, string nf, Cuenta[] c)
        {
            nombre = nom;
            apellido = ape;
            nif = nf;
            cuentas = c;
        }

        // métodos de acceso para consultar nombre, apellido y nif
        public string getNombre ()
        {
            return nombre;
        }
        public string getApellido ()
        {
            return apellido;
        }
        public string getNif()
        {
            return nif;
        }

        // Métodos - Comportamiento del cliente:
        // Puede Consultar el saldo de sus cuentas.
        public double ConsultarSaldo(int num)
        {
            return cuentas[num].getSaldo();
        }

        // Ingresar dinero en una de sus cuentas.
        public void IngresarDinero(int num, double importe)
        {
            cuentas[num].Ingresar(importe);
        }

        // Retirar dinero de una de sus cuentas
        public void RetirarDinero(int num, double importe)
        {
            cuentas[num].Retirar(importe);
        }

    }
}