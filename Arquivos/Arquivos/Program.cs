using System;
using System.IO;

class Program
{
    static void Main()
    {
        string caminho = "dados.txt";

        File.WriteAllText(caminho, "Nome: Matheus\nIdade: 18");

        string conteudo = File.ReadAllText(caminho);
        Console.WriteLine(conteudo);
    }
}
