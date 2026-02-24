namespace att02.Exercicios;

public static class Ex52_ContarCaracteres
{
    public static void Executar()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine() ?? "";
        Console.WriteLine($"Quantidade de caracteres: {frase.Length}");
    }
}