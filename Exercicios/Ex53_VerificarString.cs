namespace att02.Exercicios;

public static class Ex53_VerificarString
{
    public static void Executar()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine() ?? "";

        Console.Write("Digite a palavra para procurar: ");
        string palavra = Console.ReadLine() ?? "";

        bool contem = frase.Contains(palavra, StringComparison.OrdinalIgnoreCase);

        Console.WriteLine(contem ? "A frase contém a palavra." : "A frase NÃO contém a palavra.");
    }
}