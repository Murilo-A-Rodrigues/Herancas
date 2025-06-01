using System;
using Biblioteca.Model;

class Program
{
    static void Main()
    {
        var livro1 = new Livro("O Chamado de Cthulhu", "H.P. Lovecraft");
        var leitor1 = new Leitor("Murilo");

        var emprestimo1 = leitor1.RealizarEmprestimo(livro1);

        Console.WriteLine($"Livro '{livro1.Titulo}' emprestado para {leitor1.Nome} em {emprestimo1.DataEmprestimo}");

        leitor1.DevolverLivro(emprestimo1);
        Console.WriteLine($"Livro '{livro1.Titulo}' deve ser devolvido até {emprestimo1.DataDevolucao}");
    }
}