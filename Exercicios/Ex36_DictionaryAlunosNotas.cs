namespace att02.Exercicios;

public static class Ex36_DictionaryAlunosNotas
{
    public static void Executar()
    {
        Dictionary<string, double> alunos = new()
        {
            ["Ana"] = 8.5,
            ["Bruno"] = 7.0,
            ["Carla"] = 9.2
        };
        Console.WriteLine("Alunos e notas criados: Ana, Bruno, Carla.");
    }
}
