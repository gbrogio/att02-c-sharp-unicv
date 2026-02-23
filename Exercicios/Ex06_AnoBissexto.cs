namespace att02.Exercicios;

public static class Ex06_AnoBissexto
{
    public static void Executar()
    {
        int ano = 2024;
        bool bissexto = (ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0);
        Console.WriteLine($"{ano} {(bissexto ? "é" : "não é")} bissexto.");
    }
}
