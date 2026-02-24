using System;

namespace Exercicio24{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Exercicio 24: Contar Positivos");

            int[] numeros = { -10, 5, 20, -3, 8 };

            int positivos = 0;

            foreach (int n in numeros){
                if (n > 0){
                    positivos++;
                }
            }

            Console.WriteLine("Total positivos: " + positivos);

            Console.ReadLine();
        }
    }
}