namespace att02.Exercicios;

public static class Ex19_Fatorial
{
    public static void Executar()
    {
        int n = 5;
        int fat = 1;
        for (int i = 1; i <= n; i++)
            fat *= i;
        Console.WriteLine($"{n}! = {fat}");
    }
}
