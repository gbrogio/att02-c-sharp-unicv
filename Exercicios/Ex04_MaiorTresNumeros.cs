namespace att02.Exercicios;
    public static class Ex04_MaiorTresNumeros
    {
        public static void Executar() 
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro numero: ");
            int c = int.Parse(Console.ReadLine());

            if (a >= b && a >= c)
                Console.WriteLine($"O numero maior e: {a}");
            else if (b >= a && b >= c)
                Console.WriteLine($"O numero maior e: {b}");
            else
                Console.WriteLine($"O numero maior e: {c}");

             Console.ReadKey();
        }
    }

