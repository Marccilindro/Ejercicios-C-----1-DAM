using System;

namespace EjercicioPractico02
{
    class Plantilla
    {
        // Atributos o Datos
        private List<Personas> plant = null;


        // Construcion
        public Plantilla()
        {
            plant = new List<Personas>();
        }


        // Metodos de Interfaz
        public void Add(Persona per)
        {
            plant.Add(per);
        }

        public double CalcularPromedio()
        {
            double promedio = 0;
            foreach (Persona per in plant)
            {
                promedio += per.Edad;
            }
            return promedio / plant.Count;
        }

    }
}