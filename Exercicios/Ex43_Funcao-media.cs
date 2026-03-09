namespace att02.Exercicios;

public static class Ex43_FuncaoMedia
{
    private static int Media(int a, int b, int c)
    {
        return (a + b + c) / 3;
    }

    public static void Executar()
    {
        int a = 6;
        int b = 76;
        int c = 38;

        int res = Media(a, b, c);
        Console.WriteLine($"A média entre {a}, {b} e {c} é {res}");
    }
}