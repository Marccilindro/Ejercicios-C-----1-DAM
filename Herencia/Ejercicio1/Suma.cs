using System;

namespace Herencia
{
    class Suma : Operacion
    {
        public double Operar()
        {
            resultado = operador1 + operador2;
            return resultado;
        }
    }
}