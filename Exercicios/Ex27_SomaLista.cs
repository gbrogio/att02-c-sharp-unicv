namespace att02.Exercicios;

public static class Ex27_SomaLista
{
    public static void Executar()
    {
        List<int> lista = new() { 10, 20, 30, 40 };
        int soma = 0;
        foreach (int x in lista) soma += x;
        Console.WriteLine($"Soma dos elementos: {soma}");
    }
}
