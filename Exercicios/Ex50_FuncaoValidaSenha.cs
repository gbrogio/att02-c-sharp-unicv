namespace att02.Exercicios;

public static class Ex50_FuncaoValidaSenha
{
    static bool ValidaSenha(string senha) => senha == "1234";

    public static void Executar()
    {
        bool ok = ValidaSenha("1234");
        Console.WriteLine($"ValidaSenha(\"1234\") = {ok}");
    }
}
