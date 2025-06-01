using System;

namespace Biblioteca.Model
{
    public class Emprestimo
    {
        public Leitor Leitor { get; }
        public Livro Livro { get; }
        public DateTime DataEmprestimo { get; }
        public DateTime? DataDevolucao { get; private set; }

        public Emprestimo(Leitor leitor, Livro livro)
        {
            Leitor = leitor;
            Livro = livro;
            DataEmprestimo = DateTime.Now;
        }

        public void Devolver()
        {
            DataDevolucao = DateTime.Now.AddDays(10);
        }
    }
}