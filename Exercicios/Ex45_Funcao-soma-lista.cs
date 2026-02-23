static int somalista(List<int> numeros)
{
    int soma = 0;
    foreach (int n in numeros)
    {
        soma += n;
    }
    return soma;
}

List<int> lista = new List<int> { 7, 10, 24, 36 };
int res = somalista(lista);
foreach(int n in lista)
{
    Console.WriteLine(n);
}
Console.WriteLine($"O resultado da soma dos números da lista é {res}");