namespace att02.Exercicios;

public static class Ex56_FormataData
{
    public static void Executar()
    {
        DateTime hoje = DateTime.Now;
        Console.WriteLine($"Data atual (dd/MM/yyyy): {hoje:dd/MM/yyyy}");
    }
}
