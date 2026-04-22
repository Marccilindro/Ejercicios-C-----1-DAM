using System;
namespace SaltoDeLongitud
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Primer objeto: saltador1
            // Creado con el constructor que pide sus datos por teclado
            SaltadorDeLongitud saltador1 = new SaltadorDeLongitud();
            // Segundo objeto: saltador2
            // Creado con el constructor que recibe los datos por parámetro
            SaltadorDeLongitud saltador2;
            saltador2 = new SaltadorDeLongitud("Juan Marqués", 25, 1.80, 6);
            // Muestra la información de los dos saltadores
            saltador1.MostrarInformacion();
            saltador2.MostrarInformacion();
            Console.ReadKey();
            Console.Clear(); // Barrido de pantalla
                             // Agrega la información de 3 saltos / marcas para cada saltador
                             // Se podrían pedir por teclado haciendo la programación
            correspondiente.
            Console.WriteLine("\nSe agregan 3 saltos/marcas para cada saltador\n");
            saltador1.AgregarMarca(5.23);
            saltador1.AgregarMarca(4.78);
            saltador1.AgregarMarca(5.12);
            saltador2.AgregarMarca(4.29);
            saltador2.AgregarMarca(5.56);
            saltador2.AgregarMarca(6.01);
            // Vuelve a mostrar la información de los dos saltadores
            saltador1.MostrarInformacion();
            saltador2.MostrarInformacion();
            // Visualización de mejor marca de cada saltador y promedio marca
            //en saltos
            Console.WriteLine("\nSaltador: {0} --> Mejor marca: {1}",
            saltador1.Nombre, saltador1.ObtenerMejorMarca());
            Console.WriteLine("Saltador: {0} --> Promedio de marcas: {1:N}",
            saltador1.Nombre, saltador1.ObtenerPromedioMarcas());
            Console.WriteLine("\nSaltador: {0} --> Mejor marca: {1}",
            saltador2.Nombre, saltador2.ObtenerMejorMarca());
            Console.WriteLine("Saltador: {0} --> Promedio de marcas: {1:N}",
            saltador2.Nombre, saltador2.ObtenerPromedioMarcas());
            Console.ReadKey();
        }
    }
}