namespace Utilidades;

public class Utiles
{
    private static char CalculaLetra(int valor)
    {
        const string tabla = "TRWAGMYFPDXBNJZSQVHLCKET";
        int indice;

        indice = (int)valor % 23;
        return tabla[indice];
    }

    public static string CalcularLetraNIF(string valorDNI)
    {
        valorDNI = valorDNI.ToUpper();
        char letra = CalculaLetra(Convert.ToInt32(valorDNI));
        return valorDNI + letra;

    }

    public static bool ValidarLetraNIF(string valorNIF)
    {

        valorNIF = valorNIF.ToUpper();
        char letra1 = valorNIF[valorNIF.Length - 1];
        string dni = valorNIF.Substring(0, valorNIF.Length - 1);
        char letra2 = CalculaLetra(int.Parse(dni));
        Console.WriteLine("Letra1: {0} --- Letra2: {1}", letra1, letra2);
        return (letra1 == letra2) ? true : false;
    }



}
