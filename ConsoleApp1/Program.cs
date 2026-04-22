using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Uso de la clase DateTime creando un objeto de dicha clase
            DateTime t = new DateTime();
            t = Convert.ToDateTime("21/12/2025");
            Console.WriteLine("\nFecha: {0:D}", t);
            Console.WriteLine("Día de la semana de la fecha: {0:dddd}", t);
            Console.WriteLine("Año de la fecha: {0}", t.Year);

            // uso de miembros estáticos de la clase DateTime
            Console.WriteLine("\nFecha de hoy: {0}", DateTime.Now);
            Console.WriteLine("Fecha de hoy: {0:d}", DateTime.Now);
            Console.WriteLine("Fecha de hoy: {0:D}", DateTime.Now);
            Console.WriteLine("Hora de hoy: {0:t}", DateTime.Now);
            Console.WriteLine("Hora de hoy: {0:T}", DateTime.Now);

            // Estraer la hora y los minutos
            int hora = DateTime.Now.Hour;
            int minutos = DateTime.Now.Minute;
            Console.WriteLine($"\nhora: {hora} - minuto: {minutos}");

            // añadir 10 días a la fecha de hoy y visualizarla.
            Console.WriteLine("\nNueva Fecha: {0:D}", DateTime.Now.AddDays(10));

            // Día de la semana de hoy (nombre).
            Console.WriteLine("\nNúmero de día de la semana de hoy: {0}", DateTime.Now.DayOfWeek);
            Console.WriteLine("Nombre de día de la semana en curso: {0:dddd}", DateTime.Now);

            // Nombre y Número de mes en curso
            Console.WriteLine("\nNúmero del día del mes en curso: {0}", DateTime.Now.Month);
            Console.WriteLine("\nNombre del mes en curso: {0:MMMM}", DateTime.Now);

            // Día del año en curso (desde el 1 al 365).
            Console.WriteLine("\nNúmero de día en el año en curso: {0}", DateTime.Now.DayOfYear);
            Console.ReadKey();

            // Diferencia entre dos fechas (necesario TimeSpan)
            DateTime fechaNac = new DateTime(1984, 12, 8);
            DateTime fechaHoy = DateTime.Now;

            TimeSpan dif = fechaHoy.Subtract(fechaNac);
            Console.WriteLine("Diferencia de tiempo: {0}", dif);
            Console.ReadLine();


        }
    }
}
