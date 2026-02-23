namespace att02.Exercicios;

public static class Ex48_FuncaoRef
{
    static void Dobra(ref int x) => x = x * 2;

    public static void Executar()
    {
        int n = 5;
        Dobra(ref n);
        Console.WriteLine($"Após Dobra(ref): n = {n}");
    }
}
