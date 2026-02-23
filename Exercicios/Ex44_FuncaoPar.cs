namespace att02.Exercicios;

public static class Ex44_FuncaoPar
{
    static bool EhPar(int n) => n % 2 == 0;

    public static void Executar()
    {
        bool r = EhPar(10);
        Console.WriteLine($"EhPar(10) = {r}");
    }
}
