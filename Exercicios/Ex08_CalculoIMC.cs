namespace att02.Exercicios;
    public static class Ex08_CalculoIMC
    {
        public static void Executar() 
        {
            Console.WriteLine("Digite o seu Peso: ");
            double p = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua Altura: ");
            double a = double.Parse(Console.ReadLine());

            double imc = p / (a * a);
            Console.WriteLine($"Seu IMC e: {imc:F2}");

            if (imc < 18.5)
                Console.WriteLine("abaixo do peso");
            else if
                (imc < 25) Console.WriteLine("Peso Normal");
            else if
                (imc < 30) Console.WriteLine("Sobrepeso");
            else 
                Console.WriteLine("Obesidade");

            Console.ReadKey();
        }
    }

