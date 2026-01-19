
using System;
using System.ComponentModel.Design;

namespace CadastroPessoal
{
    class Cadastro
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 > 0)
            {
                Console.WriteLine("O número é positivo");
            }
            else if(num1 < 0)
            {
                Console.WriteLine("O número é negativo");
            }
            else
            {
                Console.WriteLine("O número é zero");
            }


        }

    }

    }