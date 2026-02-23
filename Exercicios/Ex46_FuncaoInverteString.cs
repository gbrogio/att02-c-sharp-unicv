namespace att02.Exercicios;

public static class Ex46_FuncaoInverteString
{
    static string Inverte(string s)
    {
        char[] chars = s.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    public static void Executar()
    {
        string r = Inverte("ola");
        Console.WriteLine($"Inverte(\"ola\") = {r}");
    }
}
