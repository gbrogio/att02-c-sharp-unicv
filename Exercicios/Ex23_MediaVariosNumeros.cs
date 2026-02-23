namespace att02.Exercicios;

public static class Ex23_MediaVariosNumeros
{
    public static void Executar()
    {
        double[] nums = { 5, 8, 7, 10 };
        double soma = 0;
        foreach (double x in nums) soma += x;
        double media = soma / nums.Length;
        Console.WriteLine($"Média de {nums.Length} números = {media:F1}");
    }
}
