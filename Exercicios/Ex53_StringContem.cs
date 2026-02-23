namespace att02.Exercicios;

public static class Ex53_StringContem
{
    public static void Executar()
    {
        string frase = "O rato roeu a roupa.";
        string palavra = "roupa";
        bool tem = frase.Contains(palavra);
        Console.WriteLine($"Contém \"{palavra}\"? {tem}");
    }
}
