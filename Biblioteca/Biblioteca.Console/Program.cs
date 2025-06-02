using System;
using System.Collections.Generic;
using Biblioteca.Model;

class Program
{
    static void Main()
    {
        var livros = new List<Livro>();
        var leitores = new List<Leitor>();
        var emprestimos = new List<Emprestimo>();

        while (true)
        {
            Console.WriteLine("\n--- MENU BIBLIOTECA ---");
            Console.WriteLine("1. Cadastrar livro");
            Console.WriteLine("2. Cadastrar leitor");
            Console.WriteLine("3. Realizar empréstimo");
            Console.WriteLine("4. Devolver livro");
            Console.WriteLine("5. Listar empréstimos");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            var opcao = Console.ReadLine();

            if (opcao == "0") break;

            switch (opcao)
            {
                case "1":
                    Console.Write("Título do livro: ");
                    var titulo = Console.ReadLine();
                    Console.Write("Autor: ");
                    var autor = Console.ReadLine();
                    livros.Add(new Livro(titulo, autor));
                    Console.WriteLine("Livro cadastrado!");
                    break;

                case "2":
                    Console.Write("Nome do leitor: ");
                    var nomeLeitor = Console.ReadLine();
                    leitores.Add(new Leitor(nomeLeitor));
                    Console.WriteLine("Leitor cadastrado!");
                    break;

                case "3":
                    if (livros.Count == 0 || leitores.Count == 0)
                    {
                        Console.WriteLine("Cadastre pelo menos um livro e um leitor antes.");
                        break;
                    }
                    Console.WriteLine("Selecione o leitor:");
                    for (int i = 0; i < leitores.Count; i++)
                        Console.WriteLine($"{i + 1}. {leitores[i].Nome}");
                    int.TryParse(Console.ReadLine(), out int leitorIdx);
                    if (leitorIdx < 1 || leitorIdx > leitores.Count)
                    {
                        Console.WriteLine("Leitor inválido.");
                        break;
                    }
                    Console.WriteLine("Selecione o livro:");
                    for (int i = 0; i < livros.Count; i++)
                        Console.WriteLine($"{i + 1}. {livros[i].Titulo} ({livros[i].Autor})");
                    int.TryParse(Console.ReadLine(), out int livroIdx);
                    if (livroIdx < 1 || livroIdx > livros.Count)
                    {
                        Console.WriteLine("Livro inválido.");
                        break;
                    }
                    Console.Write("Data do empréstimo (dd/MM/yyyy): ");
                    var dataEmpStr = Console.ReadLine();
                    if (!DateTime.TryParseExact(dataEmpStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataEmprestimo))
                    {
                        Console.WriteLine("Data inválida! Use o formato dd/MM/yyyy ou verifique se a data foi digitada corretamente.");
                        break;
                    }
                    if (dataEmprestimo > DateTime.Now)
                    {
                        Console.WriteLine("O empréstimo não pode ser feito no futuro.");
                        break;
                    }
                    var leitor = leitores[leitorIdx - 1];
                    var livro = livros[livroIdx - 1];
                    var emprestimo = new Emprestimo(leitor, livro, dataEmprestimo);
                    leitor.Emprestimos.Add(emprestimo);
                    livro.Emprestar();
                    emprestimos.Add(emprestimo);
                    Console.WriteLine($"Livro '{livro.Titulo}' emprestado para {leitor.Nome} em {emprestimo.DataEmprestimo:dd/MM/yyyy}");
                    break;

                case "4":
                    if (emprestimos.Count == 0)
                    {
                        Console.WriteLine("Nenhum empréstimo registrado.");
                        break;
                    }
                    Console.WriteLine("Selecione o empréstimo para devolução:");
                    for (int i = 0; i < emprestimos.Count; i++)
                    {
                        var emp = emprestimos[i];
                        Console.WriteLine($"{i + 1}. Livro: {emp.Livro.Titulo} | Leitor: {emp.Leitor.Nome} | Empréstimo: {emp.DataEmprestimo:dd/MM/yyyy}");
                    }
                    int.TryParse(Console.ReadLine(), out int empIdx);
                    if (empIdx < 1 || empIdx > emprestimos.Count)
                    {
                        Console.WriteLine("Empréstimo inválido.");
                        break;
                    }
                    var empSelecionado = emprestimos[empIdx - 1];
                    empSelecionado.Devolver();
                    Console.WriteLine($"Livro '{empSelecionado.Livro.Titulo}' devolvido em {empSelecionado.DataDevolucao:dd/MM/yyyy} (prazo: {empSelecionado.PrazoLimiteDevolucao():dd/MM/yyyy})");
                    if (empSelecionado.DataDevolucao < DateTime.Now.Date)
                    {
                        Console.WriteLine("Atenção: O livro deveria ter sido devolvido!");
                    }
                    if (empSelecionado.DevolvidoAposPrazo())
                    {
                        Console.WriteLine("Atenção: O livro foi devolvido após o prazo de 14 dias!");
                    }
                    emprestimos.RemoveAt(empIdx - 1);
                    break;

                case "5":
                    if (emprestimos.Count == 0)
                    {
                        Console.WriteLine("Nenhum empréstimo registrado.");
                        break;
                    }
                    foreach (var emp in emprestimos)
                    {
                        Console.WriteLine($"Livro: {emp.Livro.Titulo} | Leitor: {emp.Leitor.Nome} | Empréstimo: {emp.DataEmprestimo:dd/MM/yyyy} | Devolução: {emp.DataDevolucao:dd/MM/yyyy}");
                        if (emp.DataDevolucao < DateTime.Now.Date)
                        {
                            Console.WriteLine("  -> O livro deveria ter sido devolvido!");
                        }
                        if (emp.DevolvidoAposPrazo())
                        {
                            Console.WriteLine("  -> O livro foi devolvido após o prazo de 14 dias!");
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
        Console.WriteLine("Programa encerrado.");
    }
}