using System;

// EJERCICIO 02. Programa que lea dos frases por teclado y compruebe si son iguales.

namespace EJ02
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase1, frase2;
            

            Console.Write("Introduce la primera frase: ");
            frase1 = Console.ReadLine();
            Console.Write("Introduce la primera frase: ");
            frase2 = Console.ReadLine();

            //Forma1:
            // No es la más adecuada.
            if (frase1.CompareTo(frase2) == 0)
                Console.WriteLine("Son frases iguales");
            else
                Console.WriteLine("Son frases distintas");

            // Forma2:
            //if(frase1.Equals(frase2))
            //    Console.WriteLine("Son frases iguales");
            //else
            //    Console.WriteLine("Son frases distintas");

            // Forma3:
            // if (frase1 == frase2)
            //    Console.WriteLine("Son frases iguales");
            // else
            //    Console.WriteLine("Son frases distintas");

            // Forma4:
            // bool distintas = false;
            // 
            // if (frase1.Length != frase2.Length)
            //    distintas = true;
            //else
            //    for (int i = 0; i < frase1.Length; i++)
            //    {
            //        if (frase1[i] != frase2[i])
            //        {
            //            distintas = true;
            //        }
            //    }

            //if (distintas)
            //    Console.WriteLine("Las frases son distintas");
            //else
            //    Console.WriteLine("Las frases son iguales");

            Console.ReadLine();
        }
        
    }
}
