using System.Collections.Generic;

namespace Biblioteca.Model
{
    public class Leitor
    {
        public string Nome { get; }
        public List<Emprestimo> Emprestimos { get; } = new List<Emprestimo>();

        public Leitor(string nome)
        {
            Nome = nome;
        }

        public Emprestimo RealizarEmprestimo(Livro livro)
        {
            if (!livro.Disponivel)
                throw new InvalidOperationException($"O livro '{livro.Titulo}' não está disponível.");
            var emprestimo = new Emprestimo(this, livro);
            Emprestimos.Add(emprestimo);
            livro.Emprestar();
            return emprestimo;
        }

        public void DevolverLivro(Emprestimo emprestimo)
        {
            emprestimo.Devolver();
            emprestimo.Livro.Devolver();
        }
    }
}