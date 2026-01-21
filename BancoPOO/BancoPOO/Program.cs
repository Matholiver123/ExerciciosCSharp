using System;
using System.Collections.Generic;

class BancoPoo
{
    static void Main()
    {
        Conta corrente = new ContaCorrente("Matheus", 1000);
        Conta poupanca = new ContaPoupanca("Ana", 500);

        List<Conta> contas = new List<Conta>();
        contas.Add(corrente);
        contas.Add(poupanca);

        corrente.Sacar(1300);   
        poupanca.Sacar(600); 

        corrente.Depositar(200);
        poupanca.Depositar(300);

        foreach (Conta conta in contas)
        {
            conta.MostrarSaldo();
        }
    }
}
