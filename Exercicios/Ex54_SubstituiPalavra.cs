namespace att02.Exercicios;

public static class Ex54_SubstituiPalavra
{
    public static void Executar()
    {
        string frase = "O gato subiu no telhado.";
        string nova = frase.Replace("gato", "cachorro");
        Console.WriteLine($"Nova frase: {nova}");
    }
}
