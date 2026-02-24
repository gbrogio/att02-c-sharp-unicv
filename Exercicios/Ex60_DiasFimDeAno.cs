namespace att02.Exercicios;

public static class Ex60_DiasFimDeAno
{
    public static void Executar()
    {
        DateTime hoje = DateTime.Now;
        DateTime fimAno = new DateTime(hoje.Year, 12, 31);

        int diasRestantes = (fimAno - hoje).Days;

        Console.WriteLine($"Dias restantes até o fim do ano: {diasRestantes}");
    }
}