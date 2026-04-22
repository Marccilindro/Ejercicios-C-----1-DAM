using System;

namespace Actividad1
{
    class Persona
    {
        //Atributos (datos o informacion de la clase)
        //Declaracion: <acceso> + <modficador> + <tipo> + <nombre del atributo>

        private string nombre;
        private int edad;
        private bool jubilado = false;
        private double salario;
        private double donacion; //3% del salario


        //Uso de propiedades (hace lo mismo que un get y un set)

        public string Nombre
        {
            get { return this.nombre.ToUpper(); }
            set { nombre = value; }
        }

        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                if (value < 0) edad = 0;
                else edad = value;
            }
        }

        public bool Jubilado { get { return jubilado; } }

        public double Donacion { get { return donacion; } }

        public double Salario
        {
            get
            {
                return salario;
            }
            set
            {
                if (value < 0) salario = 0;
                else salario = value;
                CalcularDonacion();
            }
        }




        //Metdos de acceso (Getters y setters)
        public string getNombre()
        {
            return nombre.ToUpper();
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public int getEdad()
        {
            return edad;
        }

        public void setEdad(int edad)
        {
            if (edad < 0)
            {
                this.edad = 0;
                Console.WriteLine("La edad introducida es erronea");
            }
            else
            {
                this.edad = edad;
            }
        }

        public string getJubilado()
        {
            if (jubilado) return "SI";
            else return "NO";
        }

        public void setSalario(double salario)
        {
            if (salario < 0)
            {
                this.salario = 0;
            }
            else
            {
                this.salario = salario;
            }
            CalcularDonacion();
        }

        public double getSalario()
        {
            return salario;
        }



        //Comportamiento (metodos o funciones que hacen la clase)
        //Declaracion: <acceso> + <modificador> + <tipo_retorno> + <nombre_metodo> + <lista de parametros (si tiene)>

        public void VerInfo()
        {
            Console.WriteLine("Te llamas {0} y tienes {1} años", nombre, edad);
            Console.WriteLine("Cobras {0:N} euros", salario);
            Console.WriteLine("Donas {0} euros", donacion);
            Console.ReadKey();
        }

        public int Cumpleaños()
        {
            edad++;
            if (edad >= 67 && jubilado == false)
            {
                jubilado = true;
            }
            return edad;
        }


        //Metodos de implementacion
        private void CalcularDonacion()
        {
            donacion = salario * 0.03;
        }
    }
}