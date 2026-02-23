namespace att02.Exercicios;

public static class Ex30_InverteLista
{
    public static void Executar()
    {
        List<int> lista = new() { 1, 2, 3, 4, 5 };
        List<int> invertida = new();
        for (int i = lista.Count - 1; i >= 0; i--)
            invertida.Add(lista[i]);
        Console.WriteLine("Original: " + string.Join(", ", lista));
        Console.WriteLine("Invertida: " + string.Join(", ", invertida));
    }
}
