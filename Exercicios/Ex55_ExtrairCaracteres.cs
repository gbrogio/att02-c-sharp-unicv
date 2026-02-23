namespace att02.Exercicios;

public static class Ex55_ExtrairCaracteres
{
    public static void Executar()
    {
        Console.Write("Digite um texto: ");
        string texto = Console.ReadLine() ?? "";
        Console.Write("Número de caracteres a extrair: ");
        if (int.TryParse(Console.ReadLine(), out int quantidade) && quantidade > 0)
        {
            string resultado = texto.Length >= quantidade ? texto.Substring(0, quantidade) : texto;
            Console.WriteLine($"Texto extraído: {resultado}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro positivo.");
        }
	}
}