public static class Ex59_EhFimDeSemana
{
    public static void Executar()
    {
        DateTime hoje = DateTime.Now;
        bool fimDeSemana = hoje.DayOfWeek == DayOfWeek.Saturday || hoje.DayOfWeek == DayOfWeek.Sunday;
        Console.WriteLine($"Hoje ({hoje.DayOfWeek}) é fim de semana? {fimDeSemana}");
    }
}