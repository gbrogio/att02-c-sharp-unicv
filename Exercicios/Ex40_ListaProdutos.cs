namespace att02.Exercicios;

public class Produto
{
    public string Nome { get; set; } = "";
    public double Preco { get; set; }
}

public static class Ex40_ListaProdutos
{
    public static void Executar()
    {
        List<Produto> produtos = new()
        {
            new Produto { Nome = "Caneta", Preco = 2.50 },
            new Produto { Nome = "Caderno", Preco = 15.00 },
            new Produto { Nome = "Lápis", Preco = 1.00 }
        };
        foreach (var p in produtos)
            Console.WriteLine($"{p.Nome}: R$ {p.Preco:F2}");
    }
}
