public class Aluno : Pessoa
{
    public double NotaFinal { get; set; }

    public Aluno(string nome, int idade, double nota)
        : base(nome, idade)
    {
        NotaFinal = nota;
    }

    public override void Apresentar()
    {
        Console.WriteLine(
            $"Olá, meu nome é {Nome}, tenho {Idade} anos e minha nota final é {NotaFinal}"
        );
    }
}
