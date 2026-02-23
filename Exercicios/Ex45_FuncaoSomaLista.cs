namespace att02.Exercicios;

public static class Ex45_FuncaoSomaLista
{
    static int SomaLista(List<int> lista)
    {
        int s = 0;
        foreach (int x in lista) s += x;
        return s;
    }

    public static void Executar()
    {
        var lista = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Soma da lista = {SomaLista(lista)}");
    }
}
