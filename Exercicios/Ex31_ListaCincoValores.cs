namespace att02.Exercicios;

public static class Ex31_ListaCincoValores
{
    public static void Executar()
    {
        List<int> lista = new();
        lista.Add(10);
        lista.Add(20);
        lista.Add(30);
        lista.Add(40);
        lista.Add(50);
        Console.WriteLine("Lista: " + string.Join(", ", lista));
    }
}
