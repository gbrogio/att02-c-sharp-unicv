namespace att02.Exercicios;

public static class Ex41_FuncaoSomaDois
{
    static int Soma(int a, int b) => a + b;

    public static void Executar()
    {
        int r = Soma(3, 7);
        Console.WriteLine($"Soma(3, 7) = {r}");
    }
}
