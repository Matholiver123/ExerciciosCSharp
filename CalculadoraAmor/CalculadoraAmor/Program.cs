using System;

namespace CalculadoraAmor
{
    class Program
    {
        static int PontuacaoAmor(string frase, int peso = 1)
        {
            Console.WriteLine("Frase recebida: " + frase);
            int pontuacao = 0;

            string fraseMinuscula = frase.ToLower().Trim();

            if (fraseMinuscula.Contains("amo"))
            {
                pontuacao += 1;
            }

            if (fraseMinuscula.Contains("elisa"))
            {
                pontuacao += 1;
            }

            pontuacao *= peso;

            return pontuacao;
        }

        static void Main(string[] args)
        {
            Console.Write("Digite uma frase: ");
            string fraseUsuario = Console.ReadLine();

            int resultado1 = PontuacaoAmor(fraseUsuario);
            Console.WriteLine("Pontuação com peso padrão: " + resultado1);

            int resultado2 = PontuacaoAmor(fraseUsuario, 5);
            Console.WriteLine("Pontuação com peso 5: " + resultado2);
        }
    }
}
