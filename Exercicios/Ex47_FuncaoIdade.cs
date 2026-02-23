namespace att02.Exercicios;

public static class Ex47_FuncaoIdade
{
    static int Idade(DateTime nascimento)
    {
        var hoje = DateTime.Today;
        int idade = hoje.Year - nascimento.Year;
        if (nascimento.Date > hoje.AddYears(-idade)) idade--;
        return idade;
    }

    public static void Executar()
    {
        var nasc = new DateTime(2000, 5, 15);
        Console.WriteLine($"Idade (nasc 15/05/2000) = {Idade(nasc)} anos");
    }
}
