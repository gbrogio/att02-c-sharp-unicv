namespace att02.Exercicios;

public static class Ex49_FuncaoListaPares
{
    static List<int> Pares(List<int> lista)
    {
        var resultado = new List<int>();
        foreach (int x in lista)
            if (x % 2 == 0) resultado.Add(x);
        return resultado;
    }

    public static void Executar()
    {
        var lista = new List<int> { 1, 2, 3, 4, 5, 6 };
        var pares = Pares(lista);
        Console.WriteLine("Pares: " + string.Join(", ", pares));
    }
}
