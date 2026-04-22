using System;

//EJERCICIO 06. Programa que solicite una vocal e indique el número / orden de esta, 
//teniendo en cuenta que la “A” sería la primera y la “U” sería la quinta.

namespace EJ06
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Utilizamos un string con todas las vocales.
            // string vocales = "AEIOU";
            // Tambien se puede utilizar un Array de caracteres.
            char[] vocales = new char[5] { 'A', 'E', 'I', 'O', 'U' }; 
            char letra;
            int posicion = -1;

            Console.Write("Introduce un caracter: ");
            letra = char.Parse(Console.ReadLine().ToUpper());
            
            for (int i = 0; i < vocales.Length; i++)
            {
                if (letra == vocales[i])
                {
                    posicion = i;
                    break;
                }
            }
            // En el caso de usar un String se podría hacer uso de:
            // Método IndexOf --> posicion = vocales.IndexOf(letra);

            if (posicion == -1)
                Console.WriteLine("la letra {0} no es una vocal", letra);
            else
                Console.WriteLine("la letra suministrada es la vocal {0}, en posición {1}", letra, posicion+1);
            Console.ReadKey();
        }
    }
}
