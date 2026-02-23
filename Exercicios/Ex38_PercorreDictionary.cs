namespace att02.Exercicios;

public static class Ex38_PercorreDictionary
{
    public static void Executar()
    {
        Dictionary<string, double> alunos = new()
        {
            ["Ana"] = 8.5,
            ["Bruno"] = 7.0
        };
        foreach (var item in alunos)
            Console.WriteLine($"{item.Key}: {item.Value}");
    }
}
