using System;

namespace LoopDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            

            do
            {
                Console.WriteLine("Digite um número:");
                 numero = int.Parse(Console.ReadLine());
            }
            while (numero != 0);
        }
    }
}