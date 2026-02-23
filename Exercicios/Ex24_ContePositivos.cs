namespace att02.Exercicios;

public static class Ex24_ContePositivos
{
    public static void Executar()
    {
        int[] nums = { 3, -1, 5, 0, -2, 8 };
        int qtd = 0;
        foreach (int x in nums) if (x > 0) qtd++;
        Console.WriteLine($"Quantidade de positivos: {qtd}");
    }
}
