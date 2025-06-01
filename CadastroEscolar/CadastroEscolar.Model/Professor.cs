using System;
using System.Collections.Generic;

namespace CadastroEscolar.Model
{
    public class Professor : Pessoa
    {
        public List<string> Disciplinas { get; set; }

        public Professor(string nome, string cpf, DateTime dataNascimento, List<string> disciplinas)
            : base(nome, cpf, dataNascimento)
        {
            Disciplinas = disciplinas;
        }

        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Disciplinas: {string.Join(", ", Disciplinas)}");
        }
    }
}