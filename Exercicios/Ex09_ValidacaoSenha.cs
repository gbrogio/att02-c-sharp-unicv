namespace att02.Exercicios;

    public static class Ex09_ValidacaoSenha
    {
        public static void Executar() 
        {
            Console.WriteLine("Digite Sua Senha: ");
            string senha = Console.ReadLine();

            if (senha == "1234")
                Console.WriteLine("Acesso Permitido");
            else 
                Console.WriteLine("Acesso Negado");

            Console.ReadKey();
        }
    }

