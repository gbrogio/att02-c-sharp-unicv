namespace att02.Exercicios;

public static class Ex50_FuncaoValidaSenha
{
    private static bool SenhaValida(string senha)
    {
        bool minuscula = false;
        bool maiuscula = false;
        bool numero = false;

        foreach (char c in senha)
        {
            if (char.IsLower(c))
            {
                minuscula = true;
            }
            else if (char.IsUpper(c))
            {
                maiuscula = true;
            }
            else if (char.IsDigit(c))
            {
                numero = true;
            }
        }

        return maiuscula && minuscula && numero;
    }

    public static void Executar()
    {
        string senha = "Cristo Jesus é fiel amigo777";

        if (SenhaValida(senha))
        {
            Console.WriteLine("Senha válida!");
        }
        else
        {
            Console.WriteLine("Senha inválida!");
        }
    }
}