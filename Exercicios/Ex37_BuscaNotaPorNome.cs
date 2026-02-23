namespace att02.Exercicios;

public static class Ex37_BuscaNotaPorNome
{
    public static void Executar()
    {
        Dictionary<string, double> alunos = new()
        {
            ["Ana"] = 8.5,
            ["Bruno"] = 7.0,
            ["Carla"] = 9.2
        };
        string nome = "Carla";
        if (alunos.TryGetValue(nome, out double nota))
            Console.WriteLine($"{nome}: nota {nota}");
        else
            Console.WriteLine($"{nome} não encontrado.");
    }
}
