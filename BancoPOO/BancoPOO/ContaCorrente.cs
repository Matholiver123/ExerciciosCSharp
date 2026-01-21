public class ContaCorrente : Conta
{
    public ContaCorrente(string titular, double saldoInicial)
        : base(titular, saldoInicial)
    {
    }

    public override void Sacar(double valor)
    {
        if (Saldo - valor >= -500)
        {
            Saldo -= valor;
        }
        else
        {
            Console.WriteLine("Limite de cheque especial excedido.");
        }
    }
}
