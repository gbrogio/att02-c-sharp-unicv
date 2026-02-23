namespace att02.Exercicios;

public static class Ex14_TipoTriangulo
{
    public static void Executar()
    {
        double a = 3, b = 3, c = 3;
        if ((a + b > c) && (a + c > b) && (b + c > a))
        {
            string tipo;
            if (a == b && b == c) tipo = "Equilátero";
            else if (a == b || a == c || b == c) tipo = "Isósceles";
            else tipo = "Escaleno";
            Console.WriteLine($"Lados {a}, {b}, {c} = triângulo {tipo}");
        }
        else
            Console.WriteLine("Não formam triângulo.");
    }
}
