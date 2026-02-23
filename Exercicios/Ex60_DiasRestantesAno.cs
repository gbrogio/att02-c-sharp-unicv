namespace att02.Exercicios;

public static class Ex60_DiasRestantesAno
{
    public static void Executar()
    {
        DateTime hoje = DateTime.Today;
        var fimDoAno = new DateTime(hoje.Year, 12, 31);
        int dias = (fimDoAno - hoje).Days;
        Console.WriteLine($"Dias restantes até 31/12/{hoje.Year}: {dias}");
    }
}
