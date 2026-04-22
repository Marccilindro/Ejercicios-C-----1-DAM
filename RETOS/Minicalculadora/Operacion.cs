namespace WFMiniCalculadora
{
    class Operacion
    {
        private double oper1 = 0;
        private double oper2 = 0;

        public Operacion(string op1, string op2)
        {
            // Con uso de método Parse (puede causar una excepción / error en tiempo de ejecución)
            // oper1 = double.Parse(op1);
            // oper2 = double.Parse(op2);

            // Uso el método TryParse... No causa excepción / error en tiempo de ejecución)
            // Si no logra convertirlos devuelve False en caso contrario devuelve True.
            if (double.TryParse(op1, out double valor1))
                oper1 = valor1;
            if (double.TryParse(op2, out double valor2))
                oper2 = valor2;
           
        }

        public string Suma()
        {
            double resultado = oper1 + oper2;
            return resultado.ToString("N");
        }

        public string Resta()
        {
            double resultado = oper1 - oper2;
            return resultado.ToString("N");
        }

        public string Multiplicacion()
        {
            double resultado = oper1 * oper2;
            return resultado.ToString("N");
        }

        public string Division()
        {
            double resultado = oper1 / oper2;
            // En caso que la división resultante sea NaN (No es un número) retorno la cadena vacía.
            // En caso que la división resultante sea infinito (division por cero) retorno la cadena vacía.
            // En caso que la división se haya producido correctamente retornamos el resultado.
            if (double.IsNaN(resultado) || double.IsInfinity(resultado)) 
                return "";
            else    
                return resultado.ToString("N");
        }
    }
    
}
