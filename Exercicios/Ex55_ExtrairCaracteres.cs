namespace att02.Exercicios;

public static class Ex55_ExtrairCaracteres
{
    public static void Executar()
    {
        Console.Write("Digite um texto: ");
        string texto = Console.ReadLine() ?? "";

        if (texto.Length >= 3)
            Console.WriteLine($"Primeiros 3 caracteres: {texto.Substring(0, 3)}");
        else
            Console.WriteLine("Texto tem menos de 3 caracteres.");
    }
}