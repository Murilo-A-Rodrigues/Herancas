using System;

namespace CadastroEscolar.Model
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }

        public Pessoa(string nome, string cpf, DateTime dataNascimento)
        {
            Nome = nome;
            CPF = cpf;
            DataNascimento = dataNascimento;
        }

        public virtual void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, CPF: {CPF}, Nascimento: {DataNascimento:dd/MM/yyyy}");
        }
    }
}