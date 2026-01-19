using System;

namespace CadastroPessoal
{
    class Cadastro
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Você é estudante? (true/false): ");
            bool estudante = bool.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("===== DADOS CADASTRADOS =====");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura);
            Console.WriteLine("Estudante: " + estudante);
        }
    }
}
