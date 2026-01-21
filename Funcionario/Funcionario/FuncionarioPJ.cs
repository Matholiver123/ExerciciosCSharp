using System;
using System.Collections.Generic;
using System.Text;

namespace Funcionario
{
    public class FuncionarioPJ : Funcionario
    {
        public FuncionarioPJ(string nome, double salario)
            : base(nome, salario)
        {
        }

        public override double CalcularBonus()
        {
            return Salario * 0.05;
        }
    }

}
