using System;
using ControleTreino.Model;

class Program
{
    static void Main()
    {
        Aluno aluno = null;

        while (true)
        {
            Console.WriteLine("\n--- MENU CONTROLE DE TREINO ---");
            Console.WriteLine("1. Cadastrar aluno");
            Console.WriteLine("2. Cadastrar treino para o aluno");
            Console.WriteLine("3. Adicionar exercício ao treino");
            Console.WriteLine("4. Editar exercício do treino");
            Console.WriteLine("5. Listar treinos e exercícios");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            var opcao = Console.ReadLine();

            if (opcao == "0") break;

            switch (opcao)
            {
                case "1":
                    Console.Write("Nome do aluno: ");
                    var nome = Console.ReadLine();
                    Console.Write("Idade: ");
                    int.TryParse(Console.ReadLine(), out int idade);
                    Console.Write("Objetivo: ");
                    var objetivo = Console.ReadLine();
                    Console.Write("Medidas corporais(altura, peso, braço, panturrilha,etc): ");
                    var info = Console.ReadLine();
                    aluno = new Aluno(nome, idade, objetivo, info);
                    Console.WriteLine("Aluno cadastrado!");
                    break;

                case "2":
                    if (aluno == null)
                    {
                        Console.WriteLine("Cadastre um aluno primeiro.");
                        break;
                    }
                    Console.Write("Data do treino (dd/MM/yyyy): ");
                    var dataStr = Console.ReadLine();
                    if (!DateTime.TryParseExact(dataStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataTreino))
                    {
                        Console.WriteLine("Data inválida! Use o formato dd/MM/yyyy ou verifique se a data foi digitada corretamente.");
                        break;
                    }
                    Console.Write("Objetivo do treino: ");
                    var objetivoTreino = Console.ReadLine();
                    Console.Write("Tipo do treino: ");
                    var tipoTreino = Console.ReadLine();
                    var treino = new Treino(dataTreino, objetivoTreino, tipoTreino);
                    aluno.Treinos.Add(treino);
                    Console.WriteLine("Treino cadastrado!");
                    break;

                case "3":
                    if (aluno == null || aluno.Treinos.Count == 0)
                    {
                        Console.WriteLine("Cadastre um aluno e um treino primeiro.");
                        break;
                    }
                    Console.WriteLine("Selecione o treino:");
                    for (int i = 0; i < aluno.Treinos.Count; i++)
                        Console.WriteLine($"{i + 1}. {aluno.Treinos[i].Tipo} ({aluno.Treinos[i].Objetivo}) - {aluno.Treinos[i].DataCriacao:dd/MM/yyyy}");
                    int.TryParse(Console.ReadLine(), out int treinoIdx);
                    if (treinoIdx < 1 || treinoIdx > aluno.Treinos.Count)
                    {
                        Console.WriteLine("Treino inválido.");
                        break;
                    }
                    var treinoSel = aluno.Treinos[treinoIdx - 1];
                    Console.Write("Nome do exercício: ");
                    var nomeEx = Console.ReadLine();
                    Console.Write("Séries: ");
                    int.TryParse(Console.ReadLine(), out int series);
                    Console.Write("Repetições: ");
                    int.TryParse(Console.ReadLine(), out int reps);
                    Console.Write("Peso (kg): ");
                    int.TryParse(Console.ReadLine(), out int peso);
                    treinoSel.Exercicios.Add(new Exercicio(nomeEx, series, reps, peso));
                    Console.WriteLine("Exercício adicionado!");
                    break;

                case "4":
                    if (aluno == null || aluno.Treinos.Count == 0)
                    {
                        Console.WriteLine("Cadastre um aluno e um treino primeiro.");
                        break;
                    }
                    Console.WriteLine("Selecione o treino:");
                    for (int i = 0; i < aluno.Treinos.Count; i++)
                        Console.WriteLine($"{i + 1}. {aluno.Treinos[i].Tipo} ({aluno.Treinos[i].Objetivo}) - {aluno.Treinos[i].DataCriacao:dd/MM/yyyy}");
                    int.TryParse(Console.ReadLine(), out int treinoIdxEdit);
                    if (treinoIdxEdit < 1 || treinoIdxEdit > aluno.Treinos.Count)
                    {
                        Console.WriteLine("Treino inválido.");
                        break;
                    }
                    var treinoEdit = aluno.Treinos[treinoIdxEdit - 1];
                    if (treinoEdit.Exercicios.Count == 0)
                    {
                        Console.WriteLine("Nenhum exercício cadastrado neste treino.");
                        break;
                    }
                    Console.WriteLine("Selecione o exercício:");
                    for (int i = 0; i < treinoEdit.Exercicios.Count; i++)
                        Console.WriteLine($"{i + 1}. {treinoEdit.Exercicios[i].Nome}");
                    int.TryParse(Console.ReadLine(), out int exIdx);
                    if (exIdx < 1 || exIdx > treinoEdit.Exercicios.Count)
                    {
                        Console.WriteLine("Exercício inválido.");
                        break;
                    }
                    var exSel = treinoEdit.Exercicios[exIdx - 1];
                    Console.Write("Nova quantidade de séries: ");
                    int.TryParse(Console.ReadLine(), out int novasSeries);
                    Console.Write("Nova quantidade de repetições: ");
                    int.TryParse(Console.ReadLine(), out int novasReps);
                    Console.Write("Novo peso (kg): ");
                    int.TryParse(Console.ReadLine(), out int novoPeso);
                    exSel.Series = novasSeries;
                    exSel.Repeticoes = novasReps;
                    exSel.Peso = novoPeso;
                    Console.WriteLine("Exercício atualizado!");
                    break;

                case "5":
                    if (aluno == null || aluno.Treinos.Count == 0)
                    {
                        Console.WriteLine("Nenhum treino cadastrado.");
                        break;
                    }
                    Console.WriteLine($"\nAluno: {aluno.Nome} | Objetivo: {aluno.Objetivo}");
                    foreach (var t in aluno.Treinos)
                    {
                        Console.WriteLine($"\nTreino: {t.Tipo} ({t.Objetivo}) - {t.DataCriacao:dd/MM/yyyy}");
                        foreach (var ex in t.Exercicios)
                        {
                            Console.WriteLine($"- {ex.Nome}: {ex.Series}x{ex.Repeticoes} com {ex.Peso}kg (Carga total: {ex.CargaTotal()}kg)");
                        }
                        Console.WriteLine($"Carga total do treino: {t.CargaTotal()}kg");
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