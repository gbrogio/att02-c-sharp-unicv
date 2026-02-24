namespace att02.Exercicios;

public static class Ex59_FimDeSemana
{
    public static void Executar()
    {
        Console.Write("Digite uma data (dd/MM/yyyy): ");
        DateTime data = DateTime.Parse(Console.ReadLine() ?? "");

        if (data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday)
            Console.WriteLine("É fim de semana.");
        else
            Console.WriteLine("Não é fim de semana.");
    }
}