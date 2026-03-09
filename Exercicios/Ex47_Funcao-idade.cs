namespace att02.Exercicios;

public static class Ex47_FuncaoIdade
{
    private static int CalcularIdade(DateTime nascimento)
    {
        int idade = DateTime.Now.Year - nascimento.Year;

        if (DateTime.Now < nascimento.AddYears(idade))
            idade--;

        return idade;
    }

    public static void Executar()
    {
        DateTime nascimento = new DateTime(2002, 8, 25);
        int idade = CalcularIdade(nascimento);
        Console.WriteLine($"Idade: {idade} anos");
    }
}
