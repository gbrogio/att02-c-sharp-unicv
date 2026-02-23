namespace att02.Exercicios;

public static class Ex36_DictionaryAlunos
{
    public static void Executar()
    {
          Console.WriteLine("------------36-----------");
          
          Dictionary<string, int> alunoNotas = new Dictionary<String, int>();
          
          alunoNotas.Add("João", 8);
          alunoNotas.Add("Maria", 9);
          alunoNotas.Add("Pedro", 7);
          alunoNotas.Add("Ana", 10);
          
          foreach (var item36 in alunoNotas)
          {
              Console.WriteLine(item36);
          }   

    }
}
