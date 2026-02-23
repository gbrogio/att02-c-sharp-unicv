static void dobra(ref int valor)
{
    valor *= 2;
}

int valor = 98;
dobra(ref valor);

Console.WriteLine($"O valor era 98 e agora é: {valor}");