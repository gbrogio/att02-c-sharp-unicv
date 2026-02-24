using System;

namespace Exercicio23{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Exercicio 23: Media de 3 numeros");

            double soma = 0;

            for (int i = 1; i <= 3; i++) {
                Console.Write("Digite um valor: ");
                soma += double.Parse(Console.ReadLine());
            }

            double media = soma / 3;

            Console.WriteLine("Media final: " + media);

            Console.ReadLine();
        }
    }
}