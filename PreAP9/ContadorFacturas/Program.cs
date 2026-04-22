using System;

namespace ContadorFacturas
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura f1 = new Factura("Juan Marques", 1450);
            Factura f2 = new Factura("Ana Lopez", 2540);
            Factura f3 = new Factura("Luis Lopez", 5410);

            List<Factura> list = new List<Factura>() { f1, f2, f3 };
            foreach (Factura f in list)
            {
                Console.WriteLine(f.VerDatosFactura());
            }
            Console.ReadKey();
        }
    }
}
