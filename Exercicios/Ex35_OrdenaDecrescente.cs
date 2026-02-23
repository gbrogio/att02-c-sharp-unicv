namespace att02.Exercicios;

public static class Ex35_OrdenaDecrescente
{
    public static void Executar()
    {
        List<int> lista = new() { 30, 10, 50, 20, 40 };
        lista.Sort((a, b) => b.CompareTo(a));
        Console.WriteLine("Decrescente: " + string.Join(", ", lista));
    }
}
