namespace att02.Exercicios;

public static class Ex26_ForeachNomes
{
    public static void Executar()
    {
        string[] nomes = { "Ana", "Bruno", "Carla", "Diego" };
        foreach (string nome in nomes)
            Console.WriteLine(nome);
    }
}
