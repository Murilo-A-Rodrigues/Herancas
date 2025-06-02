using System;
using System.Collections.Generic;
using CadastroEscolar.Model;

class Program
{
    static void Main()
    {
        var pessoas = new List<Pessoa>();

        while (true)
        {
            Console.WriteLine("\n--- MENU CADASTRO ESCOLAR ---");
            Console.WriteLine("1. Cadastrar Aluno");
            Console.WriteLine("2. Cadastrar Professor");
            Console.WriteLine("3. Cadastrar Funcionário");
            Console.WriteLine("4. Listar Pessoas");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            var opcao = Console.ReadLine();

            if (opcao == "0") break;

            switch (opcao)
            {
                case "1":
                    Console.Write("Nome: ");
                    var nomeAluno = Console.ReadLine();
                    Console.Write("CPF: ");
                    var cpfAluno = Console.ReadLine();
                    Console.Write("Data de nascimento (dd/MM/yyyy): ");
                    var dataAlunoStr = Console.ReadLine();
                    if (!DateTime.TryParseExact(dataAlunoStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataAluno))
                    {
                        Console.WriteLine("Data inválida! Use o formato dd/MM/yyyy ou verifique se a data foi digitada corretamente.");
                        break;
                    }
                    if (dataAluno > DateTime.Now)
                    {
                        Console.WriteLine("A data de nascimento não pode ser no futuro.");
                        break;
                    }
                    Console.Write("Matrícula: ");
                    var matricula = Console.ReadLine();
                    Console.Write("Turma: ");
                    var turma = Console.ReadLine();
                    pessoas.Add(new Aluno(nomeAluno, cpfAluno, dataAluno, matricula, turma));
                    Console.WriteLine("Aluno cadastrado!");
                    break;

                case "2":
                    Console.Write("Nome: ");
                    var nomeProf = Console.ReadLine();
                    Console.Write("CPF: ");
                    var cpfProf = Console.ReadLine();
                    Console.Write("Data de nascimento (dd/MM/yyyy): ");
                    var dataProfStr = Console.ReadLine();
                    if (!DateTime.TryParseExact(dataProfStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataProf))
                    {
                        Console.WriteLine("Data inválida! Use o formato dd/MM/yyyy ou verifique se a data foi digitada corretamente.");
                        break;
                    }
                    if (dataProf > DateTime.Now)
                    {
                        Console.WriteLine("A data de nascimento não pode ser no futuro.");
                        break;
                    }
                    Console.Write("Disciplinas (separe por vírgula): ");
                    var disciplinas = Console.ReadLine().Split(',');
                    pessoas.Add(new Professor(nomeProf, cpfProf, dataProf, new List<string>(disciplinas)));
                    Console.WriteLine("Professor cadastrado!");
                    break;

                case "3":
                    Console.Write("Nome: ");
                    var nomeFunc = Console.ReadLine();
                    Console.Write("CPF: ");
                    var cpfFunc = Console.ReadLine();
                    Console.Write("Data de nascimento (dd/MM/yyyy): ");
                    var dataFuncStr = Console.ReadLine();
                    if (!DateTime.TryParseExact(dataFuncStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataFunc))
                    {
                        Console.WriteLine("Data inválida! Use o formato dd/MM/yyyy ou verifique se a data foi digitada corretamente.");
                        break;
                    }
                    if (dataFunc > DateTime.Now)
                    {
                        Console.WriteLine("A data de nascimento não pode ser no futuro.");
                        break;
                    }
                    Console.Write("Setor: ");
                    var setor = Console.ReadLine();
                    pessoas.Add(new Funcionario(nomeFunc, cpfFunc, dataFunc, setor));
                    Console.WriteLine("Funcionário cadastrado!");
                    break;

                case "4":
                    foreach (var pessoa in pessoas)
                    {
                        pessoa.ExibirDados();
                        Console.WriteLine();
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