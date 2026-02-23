namespace att02.Exercicios;

public static class Ex15_Calculadora
{
    public static void Executar()
    {
        double x = 10, y = 5;
        char op = '+';
        double resultado;
        switch (op)
        {
            case '+': resultado = x + y; break;
            case '-': resultado = x - y; break;
            case '*': resultado = x * y; break;
            case '/': resultado = y != 0 ? x / y : 0; break;
            default: resultado = 0; break;
        }
        Console.WriteLine($"{x} {op} {y} = {resultado}");
    }
}
