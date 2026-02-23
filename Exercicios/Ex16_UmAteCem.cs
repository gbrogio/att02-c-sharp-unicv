namespace att02.Exercicios;

public static class Ex16_UmAteCem
{
    public static void Executar()
    {
        for (int i = 1; i <= 100; i++)
            Console.Write(i.ToString().PadLeft(2, '0') + (i % 10 == 0 ? "\n" : " "));
    }
}
