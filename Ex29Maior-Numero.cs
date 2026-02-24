using System;
using System.Collections.Generic;

namespace Exercicio29{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Exercicio 29: Maior numero");

            List<int> numeros = new List<int>();

            numeros.Add(45);
            numeros.Add(12);
            numeros.Add(89);
            numeros.Add(23);
            numeros.Add(67);

            int maior = numeros[0];

            foreach (int n in numeros){
                if (n > maior){
                    maior = n;
                }
            }

            Console.WriteLine("Maior: " + maior);

            Console.ReadLine();
        }
    }
}