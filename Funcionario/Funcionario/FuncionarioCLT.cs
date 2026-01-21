using System;
using System.Collections.Generic;
using System.Text;

namespace Funcionario
{
    public class FuncionarioCLT : Funcionario
    {
        public FuncionarioCLT(string nome, double salario)
            : base(nome, salario)
        {
        }

        public override double CalcularBonus()
        {
            return Salario * 0.10;
        }
    }

}
