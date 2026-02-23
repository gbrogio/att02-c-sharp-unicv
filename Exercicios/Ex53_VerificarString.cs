namespace att02.Exercicios;

public static class Ex53_ContemPalavra
{
    public static void Executar()
    {
        Console.Write("Digite o texto: ");
        string texto = Console.ReadLine() ?? "";
        Console.Write("Palavra a buscar: ");
        string busca = Console.ReadLine() ?? "";
        bool contem = texto.Contains(busca, StringComparison.OrdinalIgnoreCase);
        Console.WriteLine(contem ? "A palavra foi encontrada." : "Palavra não encontrada.");
    }
}