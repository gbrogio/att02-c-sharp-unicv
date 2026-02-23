public static class Ex57_DiferencaDatas
{
	public static void Executar()
	{
		DateTime data1 = new DateTime(2024, 01, 01);
		DateTime data2 = DateTime.Now;
		TimeSpan diferenca = data2 - data1;
		Console.WriteLine($"Diferença em dias: {diferenca.Days} dias.");
	}
}