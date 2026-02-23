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
            List<int> lista = new List<int> {5, 1, 3, 2, 4};
            List<int> lista2 = new List<int> { };

            lista2.Add(10);
            lista2.Add(8);
            lista2.Add(9);
            lista2.Add(6);
            lista2.Add(7); 

            lista2.Remove(9);
            
            Console.WriteLine("------------32-----------");
            
            foreach (int i in lista2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
