
using System;
namespace FrutaColor 
{ 
    class Fruta
{
        static void Main(string[] args)
        {
            Console.Write("Digite o nome de uma fruta: ");
            String fruta = Console.ReadLine();


            switch (fruta)
            {
                case "maça":
                    Console.WriteLine("Maçã é vermelha!");
                    break;
                case "banana":
                    Console.WriteLine("Banana é amarela!");
                    break;
                case "laranja":
                    Console.WriteLine("Laranja é laranja!");
                    break;
                case "uva":
                    Console.WriteLine("Uva é roxa!");
                    break;
                case "kiwi":
                    Console.WriteLine("Kiwi é verde!");
                    break;
                default:
                    Console.WriteLine("Fruta inválido");
                    break;
            }
        }

}
}