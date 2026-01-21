using System;

namespace Conta_Corrente
{
    public class Conta
    {
        public string Titular { get; set; }
        protected double Saldo { get; set; }

        public Conta(string titular, double saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
        }

        public virtual void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        public void MostrarSaldo()
        {
            Console.WriteLine($"Titular: {Titular} | Saldo: R$ {Saldo}");
        }
    }
}
