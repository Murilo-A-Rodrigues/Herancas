using System;
using System.Collections.Generic;
using Recrutamento.Model;

class Program
{
    static void Main()
    {
        var candidatos = new List<Candidato>();
        var vagas = new List<Vaga>();
        var candidaturas = new List<Candidatura>();

        while (true)
        {
            Console.WriteLine("\n--- MENU RECRUTAMENTO ---");
            Console.WriteLine("1. Cadastrar candidato");
            Console.WriteLine("2. Cadastrar vaga");
            Console.WriteLine("3. Realizar candidatura");
            Console.WriteLine("4. Listar vagas de um candidato");
            Console.WriteLine("5. Listar candidatos de uma vaga");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            var opcao = Console.ReadLine();

            if (opcao == "0") break;

            switch (opcao)
            {
                case "1":
                    Console.Write("Nome do candidato: ");
                    var nome = Console.ReadLine();
                    Console.Write("Email: ");
                    var email = Console.ReadLine();
                    Console.Write("Currículo: ");
                    var curriculo = Console.ReadLine();
                    candidatos.Add(new Candidato(nome, email, curriculo));
                    Console.WriteLine("Candidato cadastrado!");
                    break;

                case "2":
                    Console.Write("Título da vaga: ");
                    var titulo = Console.ReadLine();
                    Console.Write("Empresa: ");
                    var empresa = Console.ReadLine();
                    Console.Write("Descrição: ");
                    var descricao = Console.ReadLine();
                    vagas.Add(new Vaga(titulo, empresa, descricao));
                    Console.WriteLine("Vaga cadastrada!");
                    break;

                case "3":
                    if (candidatos.Count == 0 || vagas.Count == 0)
                    {
                        Console.WriteLine("Cadastre pelo menos um candidato e uma vaga antes.");
                        break;
                    }
                    Console.WriteLine("Selecione o candidato:");
                    for (int i = 0; i < candidatos.Count; i++)
                        Console.WriteLine($"{i + 1}. {candidatos[i].Nome}");
                    int.TryParse(Console.ReadLine(), out int candIdx);
                    if (candIdx < 1 || candIdx > candidatos.Count)
                    {
                        Console.WriteLine("Candidato inválido.");
                        break;
                    }
                    Console.WriteLine("Selecione a vaga:");
                    for (int i = 0; i < vagas.Count; i++)
                        Console.WriteLine($"{i + 1}. {vagas[i].Titulo}");
                    int.TryParse(Console.ReadLine(), out int vagaIdx);
                    if (vagaIdx < 1 || vagaIdx > vagas.Count)
                    {
                        Console.WriteLine("Vaga inválida.");
                        break;
                    }
                    Console.Write("Status da candidatura (em análise, aprovada, rejeitada): ");
                    var status = Console.ReadLine();
                    var candidatura = new Candidatura(candidatos[candIdx - 1], vagas[vagaIdx - 1], status);
                    candidaturas.Add(candidatura);
                    Console.WriteLine("Candidatura registrada!");
                    break;

                case "4":
                    if (candidatos.Count == 0)
                    {
                        Console.WriteLine("Nenhum candidato cadastrado.");
                        break;
                    }
                    Console.WriteLine("Selecione o candidato:");
                    for (int i = 0; i < candidatos.Count; i++)
                        Console.WriteLine($"{i + 1}. {candidatos[i].Nome}");
                    int.TryParse(Console.ReadLine(), out int candIdxList);
                    if (candIdxList < 1 || candIdxList > candidatos.Count)
                    {
                        Console.WriteLine("Candidato inválido.");
                        break;
                    }
                    var candidato = candidatos[candIdxList - 1];
                    Console.WriteLine($"\nVagas para as quais {candidato.Nome} se candidatou:");
                    if (candidato.Candidaturas.Count == 0)
                        Console.WriteLine("Nenhuma candidatura registrada.");
                    else
                        foreach (var c in candidato.Candidaturas)
                            Console.WriteLine($"- {c.Vaga.Titulo} ({c.Status}, enviada em {c.DataEnvio:dd/MM/yyyy})");
                    break;

                case "5":
                    if (vagas.Count == 0)
                    {
                        Console.WriteLine("Nenhuma vaga cadastrada.");
                        break;
                    }
                    Console.WriteLine("Selecione a vaga:");
                    for (int i = 0; i < vagas.Count; i++)
                        Console.WriteLine($"{i + 1}. {vagas[i].Titulo}");
                    int.TryParse(Console.ReadLine(), out int vagaIdxList);
                    if (vagaIdxList < 1 || vagaIdxList > vagas.Count)
                    {
                        Console.WriteLine("Vaga inválida.");
                        break;
                    }
                    var vaga = vagas[vagaIdxList - 1];
                    Console.WriteLine($"\nCandidatos para a vaga '{vaga.Titulo}':");
                    if (vaga.Candidaturas.Count == 0)
                        Console.WriteLine("Nenhuma candidatura registrada.");
                    else
                        foreach (var c in vaga.Candidaturas)
                            Console.WriteLine($"- {c.Candidato.Nome} ({c.Status}, {c.DataEnvio:dd/MM/yyyy})");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
        Console.WriteLine("Programa encerrado.");
    }
}