using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Aluno aluno = new Aluno("Matheus", 18, 8.5);
        Professor professor = new Professor("Carlos", 40, 3500);

        List<Pessoa> pessoas = new List<Pessoa>();
        pessoas.Add(aluno);
        pessoas.Add(professor);

        foreach (Pessoa pessoa in pessoas)
        {
            pessoa.Apresentar();
        }
    }
}
