namespace att02.Exercicios;

public static class Ex58_AdicionaTrintaDias
{
    public static void Executar()
    {
        DateTime hoje = DateTime.Today;
        DateTime daquiTrinta = hoje.AddDays(30);
        Console.WriteLine($"Hoje: {hoje:dd/MM/yyyy} -> +30 dias: {daquiTrinta:dd/MM/yyyy}");
    }
}
