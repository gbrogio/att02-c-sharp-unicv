namespace att02.Exercicios;

public static class Ex41_FuncaoSoma
{
    private static int Soma(int a, int b)
    {
        return a + b;
    }

    public static void Executar()
    {
        int a = 0;
        int b = 7;

        int result = Soma(a, b);
        Console.WriteLine($"A soma entre {a} e {b} resulta em {result}");
    }
}