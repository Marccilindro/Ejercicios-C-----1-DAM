using System;
using System.Collections;
using System.Collections.Generic;

namespace Actividad1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos una primera instancia de la clase Persona
            Persona per1 = new Persona();
            per1.setNombre("Marco");
            per1.setEdad(18);
            per1.setSalario(2000);
            per1.VerInfo();

            Console.WriteLine(per1.getNombre() + " has cumplido" + per1.Cumpleaños());
            Console.WriteLine("Estas jubilado: {0}", per1.getJubilado());
            Console.WriteLine("Cobras {0} euros", per1.getSalario());

            //Creamos una segunda instancia de la clase Persona
            Persona per2 = new Persona();
            per2.Nombre = "Ana";
            per2.Edad = 32;
            per2.Salario = 1600;
            Console.WriteLine("{0}", per2.Jubilado);
            per2.VerInfo();

            Console.ReadKey();

            //Creamos una tercera instancia de persona
            Persona per3 = new Persona() { Nombre = "Luis", Edad = 28, Salario = 4000 };
            per3.VerInfo();
            Console.ReadKey();


            //Array de 3 personas
            Persona[] plantilla1 = new Persona[3];
            plantilla1[0] = per1;
            plantilla1[1] = per2;
            plantilla1[2] = per3;
            for (int i = 0; i < plantilla1.Length; i++)
            {
                Console.WriteLine("Persona {0}: {1}", i + 1, plantilla1[i].Nombre);
            }


            //Una lista de personas debilmente tipada
            ArrayList plantilla2 = new ArrayList();
            /*plantilla2.AddRange(plantilla1); Carga toda la info del array */
            plantilla2.Add(per1);
            plantilla2.Add(per2);
            plantilla2.Add(per3);
            foreach (Persona per in plantilla2)
            {
                Console.WriteLine("Nombre: {0}", per.Nombre);
            }


            //Una lista de personaa fuertemente tipada
            List<Persona> plantilla3 = new List<Persona>();
            plantilla3.Add(per1);
            plantilla3.Add(per2);
            plantilla3.Add(per3);
            foreach (Persona per in plantilla2)
            {
                Console.WriteLine("Nombre: {0}", per.Nombre);
            }

        }
    }
}