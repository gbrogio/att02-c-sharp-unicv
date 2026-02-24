using System;
using System.Collections.Generic;

namespace Exercicio27{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Exercicio 27: Soma da Lista");

            List<int> numeros = new List<int>();

            numeros.Add(15);
            numeros.Add(25);
            numeros.Add(10);

            int soma = 0;

            foreach (int n in numeros){
                soma += n;
            }

            Console.WriteLine("Soma total: " + soma);

            Console.ReadLine();
        }
    }
}