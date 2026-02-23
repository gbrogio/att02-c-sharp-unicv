namespace att02.Exercicios;

public static class Ex54_SubistuaPalavra
{
	public static void Executar()
	{
		Console.Write("Digite o texto: ");
		string texto = Console.ReadLine() ?? "";
		Console.Write("Palavra a substituir: ");
		string palavraAntiga = Console.ReadLine() ?? "";
		Console.Write("Nova palavra: ");
		string palavraNova = Console.ReadLine() ?? "";
		string resultado = texto.Replace(palavraAntiga, palavraNova, StringComparison.OrdinalIgnoreCase);
		Console.WriteLine($"Texto atualizado: {resultado}");
	}
}