using System;

namespace Ejercicio3
{
    class Pelicula
    {
        private string nombre;
        private int anyoEstreno;
        List<Actor> actores;

        public Pelicula(string n, int ae, List<Actor> lista)
        {
            this.nombre = n;
            this.anyoEstreno = ae;
            actores = lista;
        }

        public void VerDatosPeli()
        {
            Console.WriteLine("Nombre de la pelicula: ", nombre);
            Console.WriteLine("Anyo de estreno: ", anyoEstreno);
            Console.WriteLine("Actores: ");
            foreach (Actor a in actores)
            {
                a.VerDatosActor();
            }
        }

        public List<Actor> getActoresMenores18()
        {
            List<Actor> actoresmenores18 = new List<Actor>();
            foreach(Actor a in actores)
            {
                if (anyoEstreno - a.getAnyoNacimiento() < 18)
                {
                    actoresmenores18.Add(a);
                }
            }
            return actoresmenores18();
        }
    }
}