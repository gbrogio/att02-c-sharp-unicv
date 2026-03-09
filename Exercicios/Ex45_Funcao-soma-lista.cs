namespace att02.Exercicios;

public static class Ex45_FuncaoSomaLista
{
    private static int SomaLista(List<int> numeros)
    {
        int soma = 0;
        foreach (int n in numeros)
        {
            soma += n;
        }
        return soma;
    }

    public static void Executar()
    {
        List<int> lista = new List<int> { 7, 10, 24, 36 };
        int res = SomaLista(lista);

        Console.WriteLine("Números da lista:");
        foreach (int n in lista)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine($"O resultado da soma dos números da lista é {res}");
    }
}