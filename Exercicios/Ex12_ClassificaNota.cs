namespace att02.Exercicios;

public static class Ex12_ClassificaNota
{
    public static void Executar()
    {
        int nota = 85;
        char conceito;
        switch (nota)
        {
            case >= 90: conceito = 'A'; break;
            case >= 80: conceito = 'B'; break;
            case >= 70: conceito = 'C'; break;
            case >= 60: conceito = 'D'; break;
            default: conceito = 'F'; break;
        }
        Console.WriteLine($"Nota {nota} = conceito {conceito}");
    }
}
