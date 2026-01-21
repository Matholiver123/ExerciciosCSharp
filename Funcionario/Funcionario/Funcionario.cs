using System;
using System.Collections.Generic;
using System.Text;

namespace Funcionario
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public abstract double CalcularBonus();
    }

}
