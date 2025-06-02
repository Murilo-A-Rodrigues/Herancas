using System;

namespace Biblioteca.Model
{
    public class Emprestimo
    {
        public Leitor Leitor { get; }
        public Livro Livro { get; }
        public DateTime DataEmprestimo { get; }
        public DateTime? DataDevolucao { get; private set; }

        public Emprestimo(Leitor leitor, Livro livro, DateTime? dataEmprestimo = null)
        {
            Leitor = leitor;
            Livro = livro;
            DataEmprestimo = dataEmprestimo ?? DateTime.Now;
        }

        // Adicione este método:
        public void Devolver()
        {
            DataDevolucao = DateTime.Now;
        }

        public DateTime PrazoLimiteDevolucao()
        {
            return DataEmprestimo.AddDays(14);
        }

        public bool DevolvidoAposPrazo()
        {
            return DataDevolucao.HasValue && DataDevolucao.Value > PrazoLimiteDevolucao();
        }
    }
}