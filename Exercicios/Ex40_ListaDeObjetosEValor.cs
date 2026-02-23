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

            List<(String nome40, int valor40)> listaProduto = new List<(String, int)>
            {
                ("Amendoim", 50),
                ("Copo", 100)
            };
            
            foreach(var produto40 in listaProduto)
            {
                Console.WriteLine($"Nome: {produto40.nome40} - Valor: {produto40.valor40}");
            }

        }
    }
}
