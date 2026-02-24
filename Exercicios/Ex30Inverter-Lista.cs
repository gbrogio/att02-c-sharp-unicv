using System;
using System.Collections.Generic;

namespace Exercicio30{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Exercicio 30: Inverter Lista");

            List<int> original = new List<int>();

            original.Add(10);
            original.Add(20);
            original.Add(30);
            original.Add(40);
            original.Add(50);

            List<int> invertida = new List<int>();

            for (int i = original.Count - 1; i >= 0; i--){
                invertida.Add(original[i]);
            }

            Console.WriteLine("Original:");
            foreach (int n in original){
                Console.Write(n + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Invertida:");
            foreach (int n in invertida){
                Console.Write(n + " ");
            }

            Console.ReadLine();
        }
    }
}