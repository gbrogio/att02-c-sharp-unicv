static string strangerthings(string texto)
{
    char[] letras = texto.ToCharArray();
    Array.Reverse(letras);
    return new string(letras);
}

string texto = "Subi no onibus";
string inverso = strangerthings(texto);
Console.WriteLine($"Frase original: {texto}");
Console.WriteLine(inverso);