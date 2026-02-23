namespace att02.Exercicios;

public static class Ex59_DataFimDeSemana
{
    public static void Executar()
    {
        DateTime d = new DateTime(2025, 2, 23);
        bool fimDeSemana = d.DayOfWeek == DayOfWeek.Saturday || d.DayOfWeek == DayOfWeek.Sunday;
        Console.WriteLine($"{d:dd/MM/yyyy} ({d.DayOfWeek}) é fim de semana? {fimDeSemana}");
    }
}
