namespace att02.Exercicios;

public static class Ex29_MaiorNaLista
{
    public static void Executar()
    {
        List<int> lista = new() { 12, 45, 8, 90, 33 };
        int maior = lista[0];
        foreach (int x in lista)
            if (x > maior) maior = x;
        Console.WriteLine($"Maior número da lista: {maior}");
    }
}
