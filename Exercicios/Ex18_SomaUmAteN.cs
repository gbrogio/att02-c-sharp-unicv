namespace att02.Exercicios;

public static class Ex18_SomaUmAteN
{
    public static void Executar()
    {
        int n = 10;
        int soma = 0;
        for (int i = 1; i <= n; i++)
            soma += i;
        Console.WriteLine($"Soma de 1 até {n} = {soma}");
    }
}
