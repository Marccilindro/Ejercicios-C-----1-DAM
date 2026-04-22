
namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** PROMEDIO DE NOTAS **");
            Console.WriteLine("");

            string alumno;
            int nota1, nota2, nota3;

            Console.Write("Dime el nombre del alumno: ");
            alumno = Console.ReadLine();

            Console.Write("Dime la primera nota: ");
            nota1 = int.Parse(Console.ReadLine());
            Console.Write("Dime la segunda nota: ");
            nota2 = int.Parse(Console.ReadLine());
            Console.Write("Dime la tercera nota: ");
            nota3 = int.Parse(Console.ReadLine());

            double promedio = (nota1 + nota2 + nota3) / 3.0;

            Console.WriteLine("======================");
            Console.WriteLine("El promedio es: " + promedio.ToString("0.00"));
            Console.ReadKey();
        }
    }
}