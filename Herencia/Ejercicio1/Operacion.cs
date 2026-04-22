using System;

namespace Herencia
{
    class Operacion
    {
        protected double operador1;
        protected double operador2;
        protected double resultado;
        
        public double Operador1 { set { operador1 = value; } }
        public double Operador2 { set { operador2 = value; } }

    }
}