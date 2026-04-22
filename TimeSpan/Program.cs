using System;

namespace UsoTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {

            // Uso básico de un intervalo (TimeSpan)
            TimeSpan intervalo = new TimeSpan();
            intervalo = TimeSpan.Zero;      // Representa el valor Cero (TimeSpan)
            Console.WriteLine(intervalo.ToString());
            intervalo = TimeSpan.MinValue;  // Representa el valor mínimo de un TimeSpan
            Console.WriteLine(intervalo.ToString());
            intervalo = TimeSpan.MaxValue;  // Representa el valor mínimo de un TimeSpan
            Console.WriteLine(intervalo.ToString());
            Console.ReadKey();

            // Creación de un intervalo de tiempo (TimeSpan) con
            // un número de horas / minutos y segundos específicos
            TimeSpan tiempo = new TimeSpan(2, 14, 18);
            Console.WriteLine("\nHora: {0,10}", tiempo);
            Console.WriteLine("Horas: {0:00}", tiempo.Hours);
            Console.WriteLine("Minutos: {0:00}", tiempo.Minutes);
            Console.WriteLine("Segundos: {0:00}", tiempo.Seconds);
            Console.ReadKey();

            // Podemos usarlo para crear un intevalo que representen diferencias entre
            // fechas y horas
            DateTime entrada = new DateTime(2026, 02, 01, 12, 30, 0);
            DateTime salida = new DateTime(2026, 02, 3, 11, 45, 23);
            Console.WriteLine("\nFecha de entrada: {0:d}", entrada);
            Console.WriteLine("Fecha de salida: {0:d}", salida);

            TimeSpan diferencia = salida - entrada;
            Console.WriteLine("\nEntrada: {0}", entrada);
            Console.WriteLine("Salida: {0}", salida);
            Console.WriteLine($"\nDiferencia: {diferencia}");
            Console.WriteLine($"Diferencia en minutos: {diferencia.TotalMinutes:N} minutos");
            Console.WriteLine("Diferencia en minutos: {0:N} minutos", diferencia.TotalMinutes);
            Console.WriteLine($"Diferencia en horas: {diferencia.TotalHours:N} horas");
            Console.WriteLine("Diferencia en horas: {0:N} horas", diferencia.TotalHours);
            Console.ReadKey();
        }
    }
}