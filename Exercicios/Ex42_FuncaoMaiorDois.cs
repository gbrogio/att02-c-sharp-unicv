namespace att02.Exercicios;

public static class Ex42_FuncaoMaiorDois
{
    static int Maior(int a, int b) => a > b ? a : b;

    public static void Executar()
    {
        int r = Maior(12, 25);
        Console.WriteLine($"Maior(12, 25) = {r}");
    }
}
