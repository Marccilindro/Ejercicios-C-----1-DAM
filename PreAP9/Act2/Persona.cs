using System;

namespace EjercicioPractico02
{
    class Persona
    {
        // Atributos (datos e informacion de la clase)
        // Declaración: <acceso> + <modificador> + <tipo> + nombre_del_atributo.

        private string nombre;
        private int edad;
        private bool jubilada;


        // Propiedad
        public int Edad { get { return edad; } }



        // Constructores de la Clase

        /* Primer constructor creado que recibe el nombre y la edad de la persona.
         * La información de jubilido/a la calcula en el constructor atendiendo a si 
         * tiene menos o más de 67 años */

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre.ToUpper();

            if (edad < 0) this.edad = 0;
            else this.edad = edad;

            if (edad >= 67) this.jubilada = true;
            else this.jubilada = false;
        }



        /* Segundo constructor creado que recibe el nombre y la edad de la persona.
         * La información de jubilado/a se le pasa como parámetro al igual que nombre y edad.
         * Este constructor sería adecuado para cuando una persona tiene más de 67 años y no
         * se ha jubilado, o por lo contrario, se ha jubilado de forma anticipada, es decir,
         * antes de los 67 años */

        public Persona(string nombre, int edad, bool jubilada)
        {
            this.nombre = nombre.ToUpper();

            if (edad < 0) this.edad = 0;
            else this.edad = edad;

            this.jubilada = jubilada;
        }


        /* Tercer constructor creado que pide los datos de la persona por teclado
        * En este caso no recibe parámetros y sustituiría al constructor heredado
        * de la clase Object. 
        * El dato jubilada se pide por teclado y no se cálcula automáticamente a partir
        * de la edad suministrada */

        public Persona()
        {
            string nom;
            int ed;
            char jub;

            Console.WriteLine("\nIntroducion de datos de persona: ");
            Console.WriteLine("\n=================================");

            Console.Write("Nombre: ");
            nom = Console.ReadLine().ToUpper();
            this.nombre = nom;

            Console.Write("Edad: ");
            ed = int.Parse(Console.ReadLine());
            this.edad = ed;

            Console.Write("Jubilado (S/N): ");
            jub = Convert.ToChar(Console.ReadLine().ToUpper());
            if (jub == 'S') this.jubilada = true;
            else this.jubilada = false;
        }




        // Comportamientos (métodos y acciones de la clase).
        // Declaración: <acceso> + <modificador> + <tipo_de_retorno> + 
        //      nombre_del_método(lista_de_parámetros_que_recibe -si recibe-).

        public void VerInfo()
        {
            Console.WriteLine("{0} tiene {1} años. Jubilada: {2}", nombre, edad, jubilada);
        }

        // Método público que incrementa la edad
        public int Cumpleaños()
        {
            edad++;
            if (edad >= 67)
            {
                jubilada = true;
            }
            return edad;
        }

    }

}