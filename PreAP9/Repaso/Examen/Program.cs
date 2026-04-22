using System;
using System.Security;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            Pastel[] pasteles = new Pastel[4];
            pasteles[0] = new Pastel();
            pasteles[1] = new Pastel();
            pasteles[2] = new Pastel();
            pasteles[3] = new Pastel();



            Console.WriteLine("\nIngredientes (1er pastel): {0}", pasteles[0].ObtenerIngredientes());

            foreach (var p in pasteles)
            {
                Console.WriteLine(p.Nombre);
            }
        }
    }
}