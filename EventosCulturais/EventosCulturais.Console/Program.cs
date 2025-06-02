using System;
using System.Collections.Generic;
using EventosCulturais.Model;

class Program
{
    static void Main()
    {
        var eventos = new List<Evento>();
        var participantes = new List<Participante>();

        while (true)
        {
            Console.WriteLine("\n--- MENU EVENTOS CULTURAIS ---");
            Console.WriteLine("1. Cadastrar Oficina");
            Console.WriteLine("2. Cadastrar Palestra");
            Console.WriteLine("3. Cadastrar Show");
            Console.WriteLine("4. Cadastrar Participante");
            Console.WriteLine("5. Inscrever Participante em Evento");
            Console.WriteLine("6. Listar eventos e participantes");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            var opcao = Console.ReadLine();

            if (opcao == "0") break;

            switch (opcao)
            {
                case "1":
                    Console.Write("Título: ");
                    var tituloOficina = Console.ReadLine();

                    Console.Write("Data (dd/MM/yyyy): ");
                    var dataStr = Console.ReadLine();
                    if (!DateTime.TryParseExact(dataStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataOficina))
                    {
                        Console.WriteLine("Data inválida! Use o formato dd/MM/yyyy ou verifique se a data foi digitada corretamente.");
                        break;
                    }

                    Console.Write("Horário (HH:mm): ");
                    var horarioOficina = Console.ReadLine();
                    if (!TimeSpan.TryParseExact(horarioOficina, "hh\\:mm", null, out TimeSpan horarioOficinaVal))
                    {
                        Console.WriteLine("Horário inválido! Use o formato HH:mm.");
                        break;
                    }

                    Console.Write("Local: ");
                    var localOficina = Console.ReadLine();
                    Console.Write("Capacidade: ");
                    int.TryParse(Console.ReadLine(), out int capacidadeOficina);
                    Console.Write("Material necessário: ");
                    var material = Console.ReadLine();
                    Console.Write("Número máximo de participantes: ");
                    int.TryParse(Console.ReadLine(), out int maxPart);

                    if (maxPart > capacidadeOficina)
                    {
                        Console.WriteLine("O número máximo de participantes não pode exceder a capacidade do local!");
                        break;
                    }

                    eventos.Add(new Oficina(tituloOficina, dataOficina, horarioOficina, localOficina, capacidadeOficina, material, maxPart));
                    Console.WriteLine("Oficina cadastrada!");
                    break;

                case "2":
                    Console.Write("Título: ");
                    var tituloPalestra = Console.ReadLine();

                    Console.Write("Data (dd/MM/yyyy): ");
                    var dataStrP = Console.ReadLine();
                    if (!DateTime.TryParseExact(dataStrP, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataPalestra))
                    {
                        Console.WriteLine("Data inválida! Use o formato dd/MM/yyyy ou verifique se a data foi digitada corretamente.");
                        break;
                    }

                    Console.Write("Horário (HH:mm): ");
                    var horarioPalestra = Console.ReadLine();
                    if (!TimeSpan.TryParseExact(horarioPalestra, "hh\\:mm", null, out TimeSpan horarioPalestraVal))
                    {
                        Console.WriteLine("Horário inválido! Use o formato HH:mm.");
                        break;
                    }

                    Console.Write("Local: ");
                    var localPalestra = Console.ReadLine();
                    Console.Write("Capacidade: ");
                    int.TryParse(Console.ReadLine(), out int capacidadePalestra);
                    Console.Write("Palestrante: ");
                    var palestrante = Console.ReadLine();
                    Console.Write("Tópico: ");
                    var topico = Console.ReadLine();
                    Console.Write("Duração prevista (min): ");
                    int.TryParse(Console.ReadLine(), out int duracao);
                    eventos.Add(new Palestra(tituloPalestra, dataPalestra, horarioPalestra, localPalestra, capacidadePalestra, palestrante, topico, duracao));
                    Console.WriteLine("Palestra cadastrada!");
                    break;

                case "3":
                    Console.Write("Título: ");
                    var tituloShow = Console.ReadLine();

                    Console.Write("Data (dd/MM/yyyy): ");
                    var dataStrS = Console.ReadLine();
                    if (!DateTime.TryParseExact(dataStrS, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataShow))
                    {
                        Console.WriteLine("Data inválida! Use o formato dd/MM/yyyy ou verifique se a data foi digitada corretamente.");
                        break;
                    }

                    Console.Write("Horário (HH:mm): ");
                    var horarioShow = Console.ReadLine();
                    if (!TimeSpan.TryParseExact(horarioShow, "hh\\:mm", null, out TimeSpan horarioShowVal))
                    {
                        Console.WriteLine("Horário inválido! Use o formato HH:mm.");
                        break;
                    }

                    Console.Write("Local: ");
                    var localShow = Console.ReadLine();
                    Console.Write("Capacidade: ");
                    int.TryParse(Console.ReadLine(), out int capacidadeShow);
                    Console.Write("Banda/Artista: ");
                    var artista = Console.ReadLine();
                    Console.Write("Estilo musical: ");
                    var estilo = Console.ReadLine();
                    Console.Write("Classificação etária: ");
                    var classificacao = Console.ReadLine();
                    eventos.Add(new Show(tituloShow, dataShow, horarioShow, localShow, capacidadeShow, artista, estilo, classificacao));
                    Console.WriteLine("Show cadastrado!");
                    break;

                case "4":
                    Console.Write("Nome do participante: ");
                    var nome = Console.ReadLine();
                    Console.Write("Email: ");
                    var email = Console.ReadLine();
                    participantes.Add(new Participante(nome, email));
                    Console.WriteLine("Participante cadastrado!");
                    break;

                case "5":
                    if (eventos.Count == 0 || participantes.Count == 0)
                    {
                        Console.WriteLine("Cadastre pelo menos um evento e um participante antes.");
                        break;
                    }
                    Console.WriteLine("Selecione o participante:");
                    for (int i = 0; i < participantes.Count; i++)
                        Console.WriteLine($"{i + 1}. {participantes[i].Nome} ({participantes[i].Email})");
                    int.TryParse(Console.ReadLine(), out int partIdx);
                    if (partIdx < 1 || partIdx > participantes.Count)
                    {
                        Console.WriteLine("Participante inválido.");
                        break;
                    }
                    Console.WriteLine("Selecione o evento:");
                    for (int i = 0; i < eventos.Count; i++)
                        Console.WriteLine($"{i + 1}. {eventos[i].Titulo} ({eventos[i].Data:dd/MM/yyyy})");
                    int.TryParse(Console.ReadLine(), out int eventoIdx);
                    if (eventoIdx < 1 || eventoIdx > eventos.Count)
                    {
                        Console.WriteLine("Evento inválido.");
                        break;
                    }
                    participantes[partIdx - 1].Inscrever(eventos[eventoIdx - 1]);
                    Console.WriteLine("Inscrição realizada!");
                    break;

                case "6":
                    if (eventos.Count == 0)
                    {
                        Console.WriteLine("Nenhum evento cadastrado.");
                        break;
                    }
                    foreach (var evento in eventos)
                    {
                        evento.ExibirInformacoes();
                        Console.WriteLine("Participantes:");
                        foreach (var p in evento.Participantes)
                        {
                            Console.WriteLine($"- {p.Nome} ({p.Email})");
                        }
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