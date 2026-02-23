namespace att02.Exercicios;

public static class Ex37_BuscarNota
{
    public static void Executar()
    {
          Dictionary<string, int> alunoNotas = new Dictionary<String, int>();
          
          alunoNotas.Add("João", 8);
          alunoNotas.Add("Maria", 9);
          alunoNotas.Add("Pedro", 7);
          alunoNotas.Add("Ana", 10);
          
            Console.WriteLine("------------37-----------");

            if (alunoNotas.TryGetValue("Ana", out int valor))
            {
                Console.WriteLine("A nota e: " + valor);
            }

    }
}
