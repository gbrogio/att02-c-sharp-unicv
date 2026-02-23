namespace att02.Exercicios;

public static class Ex33_ListaContem
{
    public static void Executar()
    {
        List<int> lista = new() { 2, 4, 6, 8 };
        int n = 6;
        bool tem = lista.Contains(n);
        Console.WriteLine($"Lista contém {n}? {(tem ? "Sim" : "Não")}");
    }
}
