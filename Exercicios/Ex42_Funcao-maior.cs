static void maior(int a, int b)
{
    int maior;
    if (a > b)
    {
        maior = a;
        Console.WriteLine($"O maior número entre {a} e {b} é {maior}.");
    }
    else if (a == b)
    {
        Console.WriteLine($"Os números {a} e {b} são iguais.");
    }
    else
    {
        maior = b;
        Console.WriteLine($"O maior número entre {a} e {b} é {maior}.");
    }
}

int a = 7;
int b = 5;

maior(a, b);