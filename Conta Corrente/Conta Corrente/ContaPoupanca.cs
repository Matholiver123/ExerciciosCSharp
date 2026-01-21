using System;

namespace Conta_Corrente
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(string titular, double saldoInicial)
            : base(titular, saldoInicial)
        {
        }

        public override void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente na poupança.");
            }
        }
    }
}
