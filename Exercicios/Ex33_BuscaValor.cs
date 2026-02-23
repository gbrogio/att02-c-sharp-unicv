namespace att02.Exercicios;

public static class Ex33_BuscaValor
{
    public static void Executar()
    {
	    List<int> lista = new List<int> {5, 1, 3, 2, 4};
            List<int> lista2 = new List<int> { };

            lista2.Add(10);
            lista2.Add(8);
            lista2.Add(9);
            lista2.Add(6);
            lista2.Add(7); 
            Console.WriteLine("------------33-----------");
            
            if (lista.Contains(3))
            {
                Console.WriteLine("O número 3 esta na lista.");
            }
            else
            {
                Console.WriteLine("O número 3 não esta na lista.");
            }     

    }
}
