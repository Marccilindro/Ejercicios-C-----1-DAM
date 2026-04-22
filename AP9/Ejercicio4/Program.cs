using System;

namespace Ejercicio4
{
    class Program
    {

        private static void menu()
        {
            Console.Clear();
            Console.WriteLine("Movimientos permitidos");
            Console.WriteLine("======================");
            Console.WriteLine("1. Arriba.");
            Console.WriteLine("2. Abajo.");
            Console.WriteLine("3. Izquierda.");
            Console.WriteLine("4. Derecha.");
            Console.WriteLine("5. Salir / Acabar.");
            Console.Write("Introduce Opción (1..5): ");
        }


        static void Main(string[] args)
        {
            Tablero t1 = new Tablero();
            int opcion;

            do
            {
                menu();
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        t1.MovArriba();
                        t1.MostrarCoord();
                        break;

                    case 2:
                        t1.MovAbajo();
                        t1.MostrarCoord();
                        break;

                    case 3:
                        t1.MovIzquierda();
                        t1.MostrarCoord();
                        break;

                    case 4:
                        t1.MovDerecha();
                        t1.MostrarCoord();
                        break;

                }
                Console.ReadKey();
            } while (opcion != 5);

            Console.WriteLine("Fin del programa");
            Console.ReadKey();
        }
    }
}