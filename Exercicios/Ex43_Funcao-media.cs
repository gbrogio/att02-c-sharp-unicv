static int media(int a, int b, int c)
{
    return a + b + c / 3;
}

int a = 6;
int b = 76;
int c = 38;

int res = media(a, b, c);
Console.WriteLine($"A média entre {a}, {b} e {c} é {res}");