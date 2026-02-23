namespace att02.Exercicios;
    public static class Ex06_AnoBissexto
    {
        public static void Executar() 
        {
            Console.WriteLine("Digite um ano:");
            int ano = int.Parse(Console.ReadLine());

            if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
                Console.WriteLine($"{ano} É Bissexto!");
            else
                Console.WriteLine($"{ano} Não é Bissexto!");

            Console.ReadKey();
        }
    }

