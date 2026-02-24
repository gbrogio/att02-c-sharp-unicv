namespace att02.Exercicios;

public static class Ex58_30Dias
{
    public static void Executar()
    {
        DateTime hoje = DateTime.Now;
        DateTime novaData = hoje.AddDays(30);

        Console.WriteLine($"Data atual: {hoje:dd/MM/yyyy}");
        Console.WriteLine($"Daqui 30 dias: {novaData:dd/MM/yyyy}");
    }
}