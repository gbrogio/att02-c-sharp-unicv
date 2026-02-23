using System.Data;

static int idade(DateTime nascimento)
{
    int idade = DateTime.Now.Year - nascimento.Year;

    if (DateTime.Now < nascimento.AddYears(idade))
        idade--;

    return idade;
}

DateTime nascimento = new DateTime(2002, 8, 25);
int iidade = idade(nascimento);
Console.WriteLine($"Idade: {iidade} anos");

