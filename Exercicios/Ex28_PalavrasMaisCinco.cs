namespace att02.Exercicios;

public static class Ex28_PalavrasMaisCinco
{
    public static void Executar()
    {
        string[] palavras = { "casa", "computador", "sol", "programação", "mar" };
        int qtd = 0;
        foreach (string p in palavras)
            if (p.Length > 5) qtd++;
        Console.WriteLine($"Palavras com mais de 5 letras: {qtd}");
    }
}
