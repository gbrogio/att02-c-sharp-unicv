namespace att02.Exercicios;

public static class Ex34_OrdenaCrescente
{
    public static void Executar()
    {
        List<int> lista = new() { 30, 10, 50, 20, 40 };
        lista.Sort();
        Console.WriteLine("Crescente: " + string.Join(", ", lista));
    }
}
