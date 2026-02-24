using System;

namespace Exercicio22{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Exercicio 22: Ler até digitar 0");

            int num;

            do {
                Console.Write("Digite um número (0 para parar): ");
                num = int.Parse(Console.ReadLine());

            } while (num != 0);

            Console.ReadLine();
        }
    }
}