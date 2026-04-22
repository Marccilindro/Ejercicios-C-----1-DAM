using System;
using System.Reflection.Metadata.Ecma335;

namespace Ejercicio4
{
    class Tablero
    {
        private int x;
        private int y;

        // Constructor
        public Tablero()
        {
            x = 5;
            y = 5;
        }

        // Metodos de acceso
        public int getPosx()
        {
            return x;
        }

        public int getPosy()
        {
            return y;
        }

        public void MostrarCoord()
        {
            Console.WriteLine("\nCoord.X = {0} -- Coord.Y = {1}", x, y);
            Console.WriteLine("<Pulsar tecla>");
        }

        // Metodos para modificar las pos
        public void MovArriba()
        {
            y++;
        }

        public void MovAbajo()
        {
            y--;
            if (y == 0) // Al llegar al final del tablero
            {
                y = 1;
            }
        }

        public void MovDerecha()
        {
            x++;
        }

        public void MovIzquierda()
        {
            x--;
            if (x == 0) // Al llegar al final del tablero
            {
                x = 1;
            }
        }

    }
}