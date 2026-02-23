namespace att02.Exercicios;

public static class Ex22_LeiaAteZero
{
    public static void Executar()
    {
        int[] numeros = { 3, 7, 2, 0 };
        int soma = 0;
        foreach (int x in numeros)
        {
            if (x == 0) break;
            soma += x;
            Console.WriteLine($"Digitado: {x}");
        }
        Console.WriteLine($"Soma até o 0: {soma}");
    }
}
