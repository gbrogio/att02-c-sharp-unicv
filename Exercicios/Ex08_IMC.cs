namespace att02.Exercicios;

public static class Ex08_IMC
{
    public static void Executar()
    {
        double peso = 70, altura = 1.75;
        double imc = peso / (altura * altura);
        string classe;
        if (imc < 18.5) classe = "Abaixo do peso";
        else if (imc < 25) classe = "Normal";
        else if (imc < 30) classe = "Sobrepeso";
        else classe = "Obesidade";
        Console.WriteLine($"Peso {peso}kg, altura {altura}m -> IMC {imc:F1} ({classe}).");
    }
}
