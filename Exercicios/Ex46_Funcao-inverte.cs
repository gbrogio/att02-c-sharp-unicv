namespace att02.Exercicios;

public static class Ex46_FuncaoInverte
{
    private static string InverterTexto(string texto)
    {
        char[] letras = texto.ToCharArray();
        Array.Reverse(letras);
        return new string(letras);
    }

    public static void Executar()
    {
        string texto = "Subi no onibus";
        string inverso = InverterTexto(texto);

        Console.WriteLine($"Frase original: {texto}");
        Console.WriteLine($"Frase invertida: {inverso}");
    }
}