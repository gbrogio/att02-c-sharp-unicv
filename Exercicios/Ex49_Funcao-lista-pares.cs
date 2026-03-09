namespace att02.Exercicios;

public static class Ex49_FuncaoListaPares
{
    private static List<int> FiltraPares(List<int> numeros)
    {
        List<int> pares = new List<int>();

        foreach (int n in numeros)
        {
            if (n % 2 == 0)
            {
                pares.Add(n);
            }
        }

        return pares;
    }

    public static void Executar()
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> pares = FiltraPares(numeros);

        Console.WriteLine("Lista completa:");
        foreach (int n in numeros)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("\nNúmeros pares da lista:");
        foreach (int p in pares)
        {
            Console.WriteLine(p);
        }
    }
}