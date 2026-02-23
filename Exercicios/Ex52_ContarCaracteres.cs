namespace att02.Exercicios;

public static class Ex52_ContarCaracteres
{
    public static void Executar()
    {
        Console.Write("Digite um texto: ");
        string texto = Console.ReadLine() ?? "";
        int quantidadeCaracteres = texto.Length;
        Console.WriteLine($"Quantidade de caracteres: {quantidadeCaracteres}");
    }
}