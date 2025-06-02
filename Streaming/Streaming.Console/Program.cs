using System;
using System.Collections.Generic;
using Streaming.Model;

class Program
{
    static void Main()
    {
        var catalogo = new List<Midia>();

        while (true)
        {
            Console.WriteLine("\n--- MENU STREAMING ---");
            Console.WriteLine("1. Cadastrar Filme");
            Console.WriteLine("2. Cadastrar Série");
            Console.WriteLine("3. Cadastrar Documentário");
            Console.WriteLine("4. Listar catálogo");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            var opcao = Console.ReadLine();

            if (opcao == "0") break;

            switch (opcao)
            {
                case "1":
                    Console.Write("Título: ");
                    var tituloFilme = Console.ReadLine();
                    Console.Write("Duração (min): ");
                    int.TryParse(Console.ReadLine(), out int duracaoFilme);
                    Console.Write("Gênero: ");
                    var generoFilme = Console.ReadLine();
                    Console.Write("Diretor: ");
                    var diretor = Console.ReadLine();
                    Console.Write("Ano: ");
                    int.TryParse(Console.ReadLine(), out int ano);
                    Console.Write("Elenco (separe por vírgula): ");
                    var elenco = Console.ReadLine().Split(',');
                    catalogo.Add(new Filme(tituloFilme, duracaoFilme, generoFilme, diretor, ano, new List<string>(elenco)));
                    Console.WriteLine("Filme cadastrado!");
                    break;

                case "2":
                    Console.Write("Título: ");
                    var tituloSerie = Console.ReadLine();
                    Console.Write("Duração total (min): ");
                    int.TryParse(Console.ReadLine(), out int duracaoSerie);
                    Console.Write("Gênero: ");
                    var generoSerie = Console.ReadLine();
                    Console.Write("Número de temporadas: ");
                    int.TryParse(Console.ReadLine(), out int temporadas);
                    var serie = new Serie(tituloSerie, duracaoSerie, generoSerie, temporadas);

                    Console.Write("Quantos episódios deseja cadastrar? ");
                    int.TryParse(Console.ReadLine(), out int qtdEp);
                    for (int i = 0; i < qtdEp; i++)
                    {
                        Console.Write($"Título do episódio {i + 1}: ");
                        var tituloEp = Console.ReadLine();
                        Console.Write($"Duração do episódio {i + 1} (min): ");
                        int.TryParse(Console.ReadLine(), out int durEp);
                        serie.AdicionarEpisodio(new Episodio(tituloEp, durEp));
                    }
                    catalogo.Add(serie);
                    Console.WriteLine("Série cadastrada!");
                    break;

                case "3":
                    Console.Write("Título: ");
                    var tituloDoc = Console.ReadLine();
                    Console.Write("Duração (min): ");
                    int.TryParse(Console.ReadLine(), out int duracaoDoc);
                    Console.Write("Gênero: ");
                    var generoDoc = Console.ReadLine();
                    Console.Write("Tema: ");
                    var tema = Console.ReadLine();
                    Console.Write("Narrador: ");
                    var narrador = Console.ReadLine();
                    catalogo.Add(new Documentario(tituloDoc, duracaoDoc, generoDoc, tema, narrador));
                    Console.WriteLine("Documentário cadastrado!");
                    break;

                case "4":
                    if (catalogo.Count == 0)
                    {
                        Console.WriteLine("Nenhuma mídia cadastrada.");
                    }
                    else
                    {
                        Console.WriteLine("\n--- CATÁLOGO ---");
                        foreach (var midia in catalogo)
                        {
                            midia.ExibirResumo();
                            Console.WriteLine();
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