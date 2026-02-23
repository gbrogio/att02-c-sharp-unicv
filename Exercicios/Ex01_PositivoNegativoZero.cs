namespace att02.Exercicios;
    public static class Ex01_PositivoNegativoZero
    {
        public static void Executar()
        {
            Console.Write("Digite um número: ");
            double num = double.Parse(Console.ReadLine());

            if (num > 0) Console.WriteLine("Positivo");
            else if (num < 0) Console.WriteLine("Negativo");
            else Console.WriteLine("Zero");
        }
    }