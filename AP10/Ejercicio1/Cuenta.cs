using System;

namespace Ejercicio1
{
    class Cuenta
    {

        private int numeroCuenta;    // número de cuenta
        private double saldo;       // saldo de la cuenta

        // Constructor para un objeto Cuenta
        public Cuenta(int numC, double cantidad)
        {
            numeroCuenta = numC;
            // El constructor controla que no se cree una cuenta con saldo negativo
            if (cantidad < 0)
            {
                saldo = 0; // si se pasa un saldo negativo lo pone a 0.
            }
            else
            {
                saldo = cantidad;
            }
        }

        // método de acceso para consultar el saldo de la cuenta
        // se podría realizar con una Propiedad Saldo (con sección get)
        public double getSaldo()
        {
            return saldo;
        }

        public void Ingresar(double cantidad)
        {
            // Solo realizamos ingresos de cantidades positivas
            if (cantidad > 0)
            {
                saldo += cantidad;
            }
        }

        public void Retirar (double cantidad)
        {
            // Sólo permitimos retirar dinero siempre que no supere el saldo
            if (saldo < cantidad)
            {
                saldo -= cantidad;
            }
        }


    }
}