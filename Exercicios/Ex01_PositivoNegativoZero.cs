namespace att02.Exercicios;

public static class Ex01_PositivoNegativoZero
{
    public static void Executar()
    {
        int n = 5;
        if (n > 0) Console.WriteLine($"{n} é positivo.");
        else if (n < 0) Console.WriteLine($"{n} é negativo.");
        else Console.WriteLine("É zero.");
    }
}
