using System;

namespace EscapeLoop
{
    class Program
    {
        static void Main(string [] args)
        {
            int numero = 2;
            int palpite;

            Console.WriteLine("Tente adivinhar o número secreto! Digite 0 para sair.");

            while (true)
            {
                Console.WriteLine("Digite seu palpite: ");
                palpite = int.Parse(Console.ReadLine());

                if (palpite == 0)
                {
                    Console.WriteLine("Saindo do jogo...");
                    break;
                }

                if (palpite == numero)
                { 
                    Console.WriteLine("Você ganhou o jogo...");
                break;
            }

                else
                {
                    Console.WriteLine("Errado! Tente novamente.");
                }
            }
            Console.WriteLine("Fim do jogo...");

        }


    }
}