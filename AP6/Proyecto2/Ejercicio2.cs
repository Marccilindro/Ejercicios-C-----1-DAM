
namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("** CONVERSION DE MEDIDAS **");
            Console.WriteLine("");

            double metros;

            Console.Write("Dame la cantidad de metros: ");
            metros = double.Parse(Console.ReadLine());

            double centimetros = metros * 100.00;
            double pulgadas = centimetros / 2.54;
            double pie = pulgadas / 12.00;
            double yarda = pie / 3.00;

            Console.WriteLine("========================");
            Console.WriteLine("CENTIMETROS: " + centimetros.ToString("0.00"));
            Console.WriteLine("PULGADAS: " + pulgadas.ToString("0.00"));
            Console.WriteLine("PIE: " + pie.ToString("0.00"));
            Console.WriteLine("YARDAS: " + yarda.ToString("0.00"));
            Console.ReadKey();
        }
    }
}