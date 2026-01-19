using System;

namespace ConversorUnidades
{
    class Program
    {
        static double Converter(double metros)
        {
            return metros * 100;
        }

        static double Converter(double metros, double peso)
        {
            return metros * 100 * peso;
        }

        static double ConverterKm(double metros)
        {
            return metros / 1000;
        }

        static void Main(string[] args)
        {
            Console.Write("Digite um valor em metros: ");
            double metros = double.Parse(Console.ReadLine());

            double resultado1 = Converter(metros);
            Console.WriteLine("Metros para centímetros: " + resultado1);

            double resultado2 = Converter(metros, 2);
            Console.WriteLine("Metros para centímetros com peso 2: " + resultado2);

            double resultado3 = ConverterKm(metros);
            Console.WriteLine("Metros para quilômetros: " + resultado3);
        }
    }
}
