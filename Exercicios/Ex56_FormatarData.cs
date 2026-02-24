namespace att02.Exercicios;

public static class Ex56_FormatarData
{
    public static void Executar()
    {
        DateTime hoje = DateTime.Now;
        Console.WriteLine($"Data atual formatada: {hoje:dd/MM/yyyy}");
    }
}