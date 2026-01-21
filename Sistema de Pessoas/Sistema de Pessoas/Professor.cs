public class Professor : Pessoa
{
    private double salario;

    public double Salario
    {
        get { return salario; }
        set
        {
            if (value >= 0)
                salario = value;
        }
    }

    public Professor(string nome, int idade, double salario)
        : base(nome, idade)
    {
        Salario = salario;
    }

    public override void Apresentar()
    {
        Console.WriteLine(
            $"Olá, meu nome é {Nome}, tenho {Idade} anos e meu salário é R$ {Salario}"
        );
    }
}
