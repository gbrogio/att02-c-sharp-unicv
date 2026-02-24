using System;
using System.Collections.Generic;

namespace Exercicio26{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Exercicio 26: Foreach com nomes");

            List<string> nomes = new List<string>();

            nomes.Add("Lucas");
            nomes.Add("Dev");
            nomes.Add("C#");

            foreach (string nome in nomes){
                Console.WriteLine(nome);
            }

            Console.ReadLine();
        }
    }
}