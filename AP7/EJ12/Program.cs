using System;

// EJERCICIO 12. Programa que permita ingresar caracteres y nos indique al final cuántos 
// se han introducido entre el ‘0’ y ‘9’. El programa finalizará cuando se le introduzca el carácter ‘.’ (Punto). 


namespace EJ12
{
    class Program
    {
        static void Main(string[] args)
        {
            char car;
            int digito=0;

            Console.Write("\nIntroduce un texto alfanumérico ('.' para finalizar): ");
            do
            {
                car = Console.ReadKey().KeyChar;  // asigna la tecla pulsada a la variable car directamente
                // car = (char) Console.Read();  //  Con esta opción es necesario pulsar <intro>
                if (car >= '0' && car <= '9')   //  if (Char.IsDigit(car)) --> mejor el uso de método IsDigit
                    digito++;
            } while (car != '.');
            Console.WriteLine("\nHan sido {0} los dígitos pulsados.", digito);
            Console.ReadKey();
        }
    }
}
