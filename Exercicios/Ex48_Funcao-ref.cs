namespace att02.Exercicios;

public static class Ex48_FuncaoRef
{
    private static void Dobra(ref int valor)
    {
        valor *= 2;
    }

    public static void Executar()
    {
        int valor = 98;
        Dobra(ref valor);

        Console.WriteLine($"O valor era 98 e agora é: {valor}");
    }
}