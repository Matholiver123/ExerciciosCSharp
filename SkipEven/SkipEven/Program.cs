using System;

namespace SkipEven
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Números de 1 a 10, pulando os pares:");

            for (int i = 1; i <= 10; i++)
            {
               if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("Fim do programa!");
        }
    }

}