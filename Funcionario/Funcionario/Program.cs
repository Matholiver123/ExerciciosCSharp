using Funcionario;
using System;

namespace Funcionario
{
    class Program
    {
        static void Main()
        {
            Funcionario clt = new FuncionarioCLT("Matheus", 3000);
            Funcionario pj = new FuncionarioPJ("Ana", 5000);

            Console.WriteLine($"Bônus CLT: R$ {clt.CalcularBonus()}");
            Console.WriteLine($"Bônus PJ: R$ {pj.CalcularBonus()}");
        }
    }
}
