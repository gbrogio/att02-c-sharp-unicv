namespace att02.Exercicios;

public static class Ex55_TresPrimeirosChars
{
    public static void Executar()
    {
        string s = "programação";
        string tres = s.Length >= 3 ? s[..3] : s;
        Console.WriteLine($"3 primeiros: \"{tres}\"");
    }
}
