namespace att02.Exercicios;

public static class Ex07_EntreDezCinquenta
{
    public static void Executar()
    {
        int n = 25;
        bool dentro = n >= 10 && n <= 50;
        Console.WriteLine($"{n} {(dentro ? "está" : "não está")} entre 10 e 50.");
    }
}
