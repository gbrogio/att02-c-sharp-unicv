namespace att02.Exercicios;

public static class Ex57_DiferencaDatas
{
    public static void Executar()
    {
        var d1 = new DateTime(2025, 1, 1);
        var d2 = new DateTime(2025, 2, 23);
        TimeSpan diff = d2 - d1;
        Console.WriteLine($"Diferença entre 01/01 e 23/02: {diff.Days} dias");
    }
}
