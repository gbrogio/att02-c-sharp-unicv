using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

          Dictionary<string, int> alunoNotas = new Dictionary<String, int>();
          
          alunoNotas.Add("João", 8);
          alunoNotas.Add("Maria", 9);
          alunoNotas.Add("Pedro", 7);
          alunoNotas.Add("Ana", 10);
          
            Console.WriteLine("------------38-----------");

            foreach (var item38 in alunoNotas)
            {
                Console.WriteLine("Aluno: " + item38.Key + " - Nota: " + item38.Value);
            }
	

        }
    }
}
