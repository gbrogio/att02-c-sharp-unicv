namespace att02.Exercicios;

public static class Ex13_FormaTriangulo
{
    public static void Executar()
    {
        double a = 3, b = 4, c = 5;
        bool formaTriangulo = (a + b > c) && (a + c > b) && (b + c > a);
        Console.WriteLine($"Lados {a}, {b}, {c}");
        Console.WriteLine(formaTriangulo ? "Formam um triângulo." : "Não formam um triângulo.");
    }
}
