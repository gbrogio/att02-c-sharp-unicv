namespace att02.Exercicios;

public static class Ex10_MenuSwitch
{
    public static void Executar()
    {
        int op = 2;
        Console.WriteLine("Menu: 1-Opção A  2-Opção B  3-Opção C  4-Opção D");
        switch (op)
        {
            case 1: Console.WriteLine("Escolhido: Opção A"); break;
            case 2: Console.WriteLine("Escolhido: Opção B"); break;
            case 3: Console.WriteLine("Escolhido: Opção C"); break;
            case 4: Console.WriteLine("Escolhido: Opção D"); break;
            default: Console.WriteLine("Opção inválida."); break;
        }
    }
}
