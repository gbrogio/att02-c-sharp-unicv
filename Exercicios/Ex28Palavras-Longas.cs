using System;
using System.Collections.Generic;

namespace Exercicio28{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Exercicio 28: Palavras longas");

            List<string> palavras = new List<string>();

            palavras.Add("Sol");
            palavras.Add("Programador");
            palavras.Add("Celta");
            palavras.Add("Computador");

            int contador = 0;

            foreach (string p in palavras){
                if (p.Length > 5){
                    contador++;
                }
            }

            Console.WriteLine("Total: " + contador);

            Console.ReadLine();
        }
    }
}