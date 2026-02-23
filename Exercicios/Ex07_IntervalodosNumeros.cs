
namespace att02.Exercicios;
    internal class Ex07_IntervalodosNumeros
    {
        public static void Executar() 
        {
            Console.WriteLine("Digite um número:");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 10 && numero <= 50)
                Console.WriteLine($"{numero} O numero esta dentro do intervalo de 10 a 50!. ");
            else
                Console.WriteLine($"{numero} O numero esta fora do intervalo de 10 a 50!. ");
        }
    }

