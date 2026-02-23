namespace att02.Exercicios;

public static class Ex56_FormatarData
{
    public static void Executar()
    {
        DateTime agora = DateTime.Now;
        Console.WriteLine($"Data atual: {agora:dd/MM/yyyy}");
    }
}