using System;
using System.Collections.Generic;
using Cursos.Model;

class Program
{
    static void Main()
    {
        var cursos = new List<Curso>();
        var alunos = new List<Aluno>();
        var professores = new List<Professor>();

        while (true)
        {
            Console.WriteLine("\n--- MENU CURSOS ---");
            Console.WriteLine("1. Cadastrar curso");
            Console.WriteLine("2. Cadastrar aluno");
            Console.WriteLine("3. Cadastrar professor");
            Console.WriteLine("4. Matricular aluno em curso");
            Console.WriteLine("5. Listar matrículas e progresso");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            var opcao = Console.ReadLine();

            if (opcao == "0") break;

            switch (opcao)
            {
                case "1":
                    if (professores.Count == 0)
                    {
                        Console.WriteLine("É necessário cadastrar pelo menos um professor antes de cadastrar um curso.");
                        break;
                    }
                    Console.Write("Nome do curso: ");
                    var nomeCurso = Console.ReadLine();
                    var curso = new Curso(nomeCurso);

                    Console.Write("Quantas aulas deseja cadastrar? ");
                    int.TryParse(Console.ReadLine(), out int qtdAulas);
                    for (int i = 0; i < qtdAulas; i++)
                    {
                        Console.Write($"Título da aula {i + 1}: ");
                        var tituloAula = Console.ReadLine();
                        Console.Write("Duração (min): ");
                        int.TryParse(Console.ReadLine(), out int duracao);

                        Console.WriteLine("Selecione o professor:");
                        for (int j = 0; j < professores.Count; j++)
                            Console.WriteLine($"{j + 1}. {professores[j].Nome}");
                        int.TryParse(Console.ReadLine(), out int profIdx);
                        if (profIdx < 1 || profIdx > professores.Count)
                        {
                            Console.WriteLine("Professor inválido.");
                            break;
                        }
                        curso.AdicionarAula(new Aula(tituloAula, duracao, professores[profIdx - 1]));
                    }
                    cursos.Add(curso);
                    Console.WriteLine("Curso cadastrado!");
                    break;

                case "2":
                    Console.Write("Nome do aluno: ");
                    var nomeAluno = Console.ReadLine();
                    alunos.Add(new Aluno(nomeAluno));
                    Console.WriteLine("Aluno cadastrado!");
                    break;

                case "3":
                    Console.Write("Nome do professor: ");
                    var nomeProf = Console.ReadLine();
                    professores.Add(new Professor(nomeProf));
                    Console.WriteLine("Professor cadastrado!");
                    break;

                case "4":
                    if (alunos.Count == 0 || cursos.Count == 0)
                    {
                        Console.WriteLine("Cadastre pelo menos um aluno e um curso antes.");
                        break;
                    }
                    Console.WriteLine("Selecione o aluno:");
                    for (int i = 0; i < alunos.Count; i++)
                        Console.WriteLine($"{i + 1}. {alunos[i].Nome}");
                    int.TryParse(Console.ReadLine(), out int alunoIdx);
                    if (alunoIdx < 1 || alunoIdx > alunos.Count)
                    {
                        Console.WriteLine("Aluno inválido.");
                        break;
                    }
                    Console.WriteLine("Selecione o curso:");
                    for (int i = 0; i < cursos.Count; i++)
                        Console.WriteLine($"{i + 1}. {cursos[i].Nome}");
                    int.TryParse(Console.ReadLine(), out int cursoIdx);
                    if (cursoIdx < 1 || cursoIdx > cursos.Count)
                    {
                        Console.WriteLine("Curso inválido.");
                        break;
                    }
                    var matricula = new Matricula(alunos[alunoIdx - 1], cursos[cursoIdx - 1]) { Progresso = 0.0 };
                    alunos[alunoIdx - 1].Matriculas.Add(matricula);
                    Console.WriteLine("Aluno matriculado no curso!");
                    break;

                case "5":
                    foreach (var aluno in alunos)
                    {
                        foreach (var matriculaAlu in aluno.Matriculas)
                        {
                            Console.WriteLine($"{matriculaAlu.Aluno.Nome} - Curso: {matriculaAlu.Curso.Nome} - Progresso: {matriculaAlu.Progresso:P0}");
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