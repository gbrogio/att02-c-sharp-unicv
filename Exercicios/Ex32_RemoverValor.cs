namespace att02.Exercicios;

public static class Ex32_RemoverValor
{
    public static void Executar()
    {
        List<int> lista = new() { 5, 10, 15, 20, 25 };
        int valor = 15;
        lista.Remove(valor);
        Console.WriteLine($"Removido {valor}. Lista: " + string.Join(", ", lista));
    }
}
