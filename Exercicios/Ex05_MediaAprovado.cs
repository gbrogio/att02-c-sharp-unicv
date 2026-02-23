namespace att02.Exercicios;

public static class Ex05_MediaAprovado
{
    public static void Executar()
    {
        double n1 = 8, n2 = 6;
        double media = (n1 + n2) / 2;
        Console.WriteLine($"Notas {n1} e {n2}, média = {media}");
        Console.WriteLine(media >= 7 ? "Aprovado." : "Reprovado.");
    }
}
