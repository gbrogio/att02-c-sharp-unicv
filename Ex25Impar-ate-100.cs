using System;

namespace Exercicio25{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Exercicio 25: Impares ate 100");

            for (int i = 1; i <= 100; i++){
                if (i % 2 != 0){
                    Console.Write(i + " ");
                }
            }

            Console.ReadLine();
        }
    }
}