
namespace att02.Exercicios;
    public static class Ex03_ParImpar
    {
        public static void Executar() 
        {
            Console.WriteLine("Digite um numero");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) Console.WriteLine("O numero é par");
            else Console.WriteLine("O numero é impar");

            Console.ReadKey();

        }
    }

