namespace att02.Exercicios;

public static class Ex09_ValidaSenha
{
    public static void Executar()
    {
        string senha = "1234";
        bool ok = senha == "1234";
        Console.WriteLine(ok ? "Senha válida." : "Senha inválida.");
    }
}
