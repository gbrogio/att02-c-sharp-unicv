namespace att02.Exercicios;

public static class Ex34_OrdemCrescente
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

            Console.WriteLine("------------34-----------");
            
            lista.Sort();
            //Console.WriteLine(lista);
            foreach (var item34 in lista)
            {
                Console.WriteLine(item34);
            }  
    }
}
