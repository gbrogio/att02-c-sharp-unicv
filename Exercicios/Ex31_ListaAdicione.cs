namespace att02.Exercicios;

public static class Ex31_ListaAdicione
{
    public static void Executar()
    {
            //31.Crie lista de inteiros e adicione 5 valores.

            List<int> lista = new List<int> {5, 1, 3, 2, 4};
            List<int> lista2 = new List<int> { };

            lista2.Add(10);
            lista2.Add(8);
            lista2.Add(9);
            lista2.Add(6);
            lista2.Add(7);

            Console.WriteLine("------------31-----------");
            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-------------------------");

            for(int j = 0; j < lista2.Count; j++)
            {
                Console.WriteLine(lista2[j]);
            }

            //Console.WriteLine(lista);
            //Console.WriteLine(lista2);            
    }
}
