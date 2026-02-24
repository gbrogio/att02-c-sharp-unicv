namespace att02.Exercicios;

public static class Ex54_SubstituaPalavra
{
    public static void Executar()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine() ?? "";

        Console.Write("Palavra a substituir: ");
        string antiga = Console.ReadLine() ?? "";

        Console.Write("Nova palavra: ");
        string nova = Console.ReadLine() ?? "";

        string resultado = frase.Replace(antiga, nova);

        Console.WriteLine($"Resultado: {resultado}");
    }
}