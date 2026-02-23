namespace att02.Exercicios;

public static class Ex43_FuncaoMedia
{
    static double Media(double a, double b) => (a + b) / 2;

    public static void Executar()
    {
        double r = Media(8, 6);
        Console.WriteLine($"Média(8, 6) = {r}");
    }
}
