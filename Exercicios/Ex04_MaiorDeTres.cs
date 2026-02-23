namespace att02.Exercicios;

public static class Ex04_MaiorDeTres
{
    public static void Executar()
    {
        int a = 3, b = 7, c = 5;
        int maior = a;
        if (b > maior) maior = b;
        if (c > maior) maior = c;
        Console.WriteLine($"Entre {a}, {b}, {c} o maior é {maior}.");
    }
}
