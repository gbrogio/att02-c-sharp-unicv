namespace att02.Exercicios;



public static class Ex51_StringMaiuscula
{
	public static void Executar()
	{
		Console.Write("Digite um texto: ");
		string texto = Console.ReadLine() ?? "";
		Console.WriteLine($"Resultado: {texto.ToUpper()}");
	}
}