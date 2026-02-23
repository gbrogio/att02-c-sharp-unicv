namespace att02.Exercicios;

public static class Ex20_Tabuada
{
    public static void Executar()
    {
        int n = 7;
        Console.WriteLine($"Tabuada do {n}:");
        for (int i = 1; i <= 10; i++)
            Console.WriteLine($"  {n} x {i} = {n * i}");
    }
}
