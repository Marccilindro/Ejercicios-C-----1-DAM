using System;

namespace Herencia
{
    class Resta : Operacion
    {
        public double Operar()
        {
            resultado = operador1 - operador2;
            return resultado;
        }
    }
}