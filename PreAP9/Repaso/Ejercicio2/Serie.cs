using System;

class Serie
{
    // Contador estático para el identificador
    private static int contador = 100;

    // Atributos
    private int idSerie;
    private string titulo;
    private int numeroTemporadas;
    private bool estrenada;
    private DateTime fechaEstreno;
    private string genero;
    private string creador;

    // =====================
    // CONSTRUCTOR POR DEFECTO
    // =====================
    public Serie()
    {
        idSerie = contador;
        contador++;

        Console.Write("Título: ");
        titulo = Console.ReadLine();

        Console.Write("Género: ");
        genero = Console.ReadLine();

        Console.Write("Creador: ");
        creador = Console.ReadLine();

        Console.Write("Número de temporadas: ");
        numeroTemporadas = int.Parse(Console.ReadLine());
        if (numeroTemporadas < 1)
        {
            numeroTemporadas = 1;
        }

        Console.Write("¿Está estrenada? (s/n): ");
        string respuesta = Console.ReadLine();

        if (respuesta == "s")
        {
            estrenada = true;
            Console.Write("Fecha de estreno (yyyy-mm-dd): ");
            fechaEstreno = DateTime.Parse(Console.ReadLine());
        }
        else
        {
            estrenada = false;
            fechaEstreno = DateTime.MinValue;
        }
    }

    // =====================================
    // CONSTRUCTOR CON TÍTULO, GÉNERO Y CREADOR
    // =====================================
    public Serie(string titulo, string genero, string creador)
    {
        idSerie = contador;
        contador++;

        this.titulo = titulo;
        this.genero = genero;
        this.creador = creador;

        numeroTemporadas = 3;
        estrenada = false;
        fechaEstreno = DateTime.MinValue;
    }

    // =========
    // GETTERS
    // =========
    public int GetIdSerie()
    {
        return idSerie;
    }

    public string GetTitulo()
    {
        return titulo;
    }

    public int GetNumeroTemporadas()
    {
        return numeroTemporadas;
    }

    public string GetGenero()
    {
        return genero;
    }

    public DateTime GetFechaEstreno()
    {
        return fechaEstreno;
    }

    public string GetEstrenada()
    {
        if (estrenada)
        {
            return "Estrenada";
        }
        else
        {
            return "No estrenada";
        }
    }

    // ======================
    // SETTERS (sin id, estreno ni fecha)
    // ======================
    public void SetTitulo(string titulo)
    {
        this.titulo = titulo;
    }

    public void SetGenero(string genero)
    {
        this.genero = genero;
    }

    public void SetCreador(string creador)
    {
        this.creador = creador;
    }

    public void SetNumeroTemporadas(int numero)
    {
        if (numero >= 1)
        {
            numeroTemporadas = numero;
        }
    }

    // ==================
    // MÉTODOS
    // ==================
    public void VisualizaInformacion()
    {
        Console.WriteLine("ID: " + idSerie);
        Console.WriteLine("Título: " + titulo);
        Console.WriteLine("Temporadas: " + numeroTemporadas);
        Console.WriteLine("Estado: " + GetEstrenada());
        Console.WriteLine("Fecha estreno: " + fechaEstreno);
        Console.WriteLine("Género: " + genero);
        Console.WriteLine("Creador: " + creador);
        Console.WriteLine("----------------------");
    }

    public void RealizarEstreno()
    {
        if (estrenada == false)
        {
            estrenada = true;
            fechaEstreno = DateTime.Now;
        }
    }
}
