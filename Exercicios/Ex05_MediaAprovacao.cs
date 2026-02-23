
namespace att02.Exercicios;
public static class Ex05_MediaAprovacao
{
    public static void Executar() 
    {
        Console.WriteLine("Digite a primeira nota");
        double nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota");
        double nota2 = double.Parse(Console.ReadLine());

        double media = (nota1 + nota2) / 2;

        if (media >= 7)
            Console.WriteLine($"Aprovado! Media: {media}");
        else
            Console.WriteLine($"Reprovado! Media: {media}");

        Console.ReadKey();

    }
}
