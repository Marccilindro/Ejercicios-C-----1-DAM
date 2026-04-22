using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Suma sum = new Suma();
            sum.operador1 = 45;
            sum.operador2 = 23;
            Console.WriteLine("El resultado de la suma es: {0}", sum.Operar());
            Console.ReadKey();

            Resta res = new Resta();
            res.operador1 = 50;
            res.operador2 = 20;
            Console.WriteLine("El resultado de la resta es: {0}", res.Operar());
            Console.ReadKey();
        }
    }
}