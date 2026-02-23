public static class Ex60_DiasParaFimDoAno
{
    public static void Executar()
    {
        DateTime hoje = DateTime.Now;
        DateTime fimDoAno = new DateTime(hoje.Year, 12, 31);
        int dias = (fimDoAno - hoje).Days;
        Console.WriteLine($"Faltam {dias} dias para o fim de {hoje.Year}.");
    }
}