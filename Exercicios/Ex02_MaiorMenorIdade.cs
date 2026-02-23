namespace att02.Exercicios;
public static class Ex02_MaiorMenorIdade
{
    public static void Executar()
    {
       Console.WriteLine("digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        if (idade >= 18) Console.WriteLine("Voce e Maior de idade");
        else Console.WriteLine("Voce e Menor de idade");

        Console.ReadKey();
    }
}