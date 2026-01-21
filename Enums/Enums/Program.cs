using Enums;
using System;

class Program
{
    static void Main()
    {
        Pedido pedido = new Pedido();
        pedido.Status = StatusPedido.AguardandoPagamento;

        Console.WriteLine(pedido.Status);

        pedido.Status = StatusPedido.Pago;
        Console.WriteLine(pedido.Status);
    }
}
