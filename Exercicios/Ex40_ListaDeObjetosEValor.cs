namespace att02.Exercicios;

public static class Ex40_ListaDeObjetosEValor
{
    public static void Executar()
    {
            List<(String nome40, int valor40)> listaProduto = new List<(String, int)>
            {
                ("Amendoim", 50),
                ("Copo", 100)
            };
            
            foreach(var produto40 in listaProduto)
            {
                Console.WriteLine($"Nome: {produto40.nome40} - Valor: {produto40.valor40}");
            }

    }
}
