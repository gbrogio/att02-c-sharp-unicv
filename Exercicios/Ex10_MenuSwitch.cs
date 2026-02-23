namespace att02.Exercicios;
    public static class Ex10_MenuSwitch
    {
        public static void Executar() 
        
        {
            Console.WriteLine("Menu: 1-Pizza | 2-Hamburguer | 3-Salada");
            Console.WriteLine("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao) 
            {
                case "1":
                    Console.WriteLine("Voce escolheu Pizza."); 
                    break;

                case "2":
                    Console.WriteLine("Voce escolheu Hamburguer."); 
                    break;

                case "3":
                    Console.WriteLine("Voce escolheu Salada."); 
                    break;
            }
            Console.ReadKey();
        }
    }

