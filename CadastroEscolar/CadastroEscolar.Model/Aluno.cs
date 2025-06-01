using System;

namespace CadastroEscolar.Model
{
    public class Aluno : Pessoa
    {
        public string Matricula { get; set; }
        public string Turma { get; set; }

        public Aluno(string nome, string cpf, DateTime dataNascimento, string matricula, string turma)
            : base(nome, cpf, dataNascimento)
        {
            Matricula = matricula;
            Turma = turma;
        }

        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Matrícula: {Matricula}, Turma: {Turma}");
        }
    }
}