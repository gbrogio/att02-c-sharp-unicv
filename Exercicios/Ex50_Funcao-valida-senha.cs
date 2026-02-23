static bool senhacheck(string senha)
{
    bool minusc = false;
    bool maiusc = false;
    bool numb = false;

    foreach (char c in senha)
    {
        if (char.IsLower(c))
        {
            minusc = true;
        }
        else if (char.IsUpper(c))
        {
            maiusc = true;
        }
        else if (char.IsDigit(c))
        {
            numb = true;
        }
        
    }
    return maiusc && minusc && numb;
}

string senha = "Cristo Jesus é fiel amigo777";

if (senhacheck(senha))
{
    Console.WriteLine("Senha válida!");
}
else
{
    Console.WriteLine("Sena inválida!");
}