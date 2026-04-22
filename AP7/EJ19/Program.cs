using System;

namespace EJ19
{
    class Program
    {
        static void Main(string[] args)
        {
            bool esPrimo;

            for (int i = 2; i <= 1000; i++)
            {
                esPrimo = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
