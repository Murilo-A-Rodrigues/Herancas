using System;
using System.Collections.Generic;
using PetShop.Model;

class Program
{
    static void Main()
    {
        var donos = new List<Dono>();
        var animais = new List<Animal>();

        while (true)
        {
            Console.WriteLine("\n--- MENU PETSHOP ---");
            Console.WriteLine("1. Cadastrar novo dono");
            Console.WriteLine("2. Cadastrar novo animal");
            Console.WriteLine("3. Listar animais e serviços disponíveis");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            var opcao = Console.ReadLine();

            if (opcao == "0") break;

            switch (opcao)
            {
                case "1":
                    Console.Write("Nome do dono: ");
                    var nomeDono = Console.ReadLine();
                    Console.Write("Telefone do dono: ");
                    var telefoneDono = Console.ReadLine();
                    donos.Add(new Dono(nomeDono, telefoneDono));
                    Console.WriteLine("Dono cadastrado com sucesso!");
                    break;

                case "2":
                    if (donos.Count == 0)
                    {
                        Console.WriteLine("Cadastre um dono antes de cadastrar um animal.");
                        break;
                    }
                    Console.WriteLine("\nQual tipo de animal deseja cadastrar?");
                    Console.WriteLine("1. Cachorro");
                    Console.WriteLine("2. Gato");
                    Console.WriteLine("3. Pássaro");
                    Console.Write("Escolha: ");
                    var tipo = Console.ReadLine();

                    Console.Write("Nome do animal: ");
                    var nome = Console.ReadLine();
                    Console.Write("Idade: ");
                    int.TryParse(Console.ReadLine(), out int idade);
                    Console.Write("Peso: ");
                    double.TryParse(Console.ReadLine(), out double peso);

                    Console.WriteLine("Selecione o dono:");
                    for (int i = 0; i < donos.Count; i++)
                        Console.WriteLine($"{i + 1}. {donos[i].Nome} ({donos[i].Telefone})");
                    int.TryParse(Console.ReadLine(), out int donoIdx);
                    if (donoIdx < 1 || donoIdx > donos.Count)
                    {
                        Console.WriteLine("Dono inválido.");
                        break;
                    }
                    var dono = donos[donoIdx - 1];

                    Animal novoAnimal = null;
                    switch (tipo)
                    {
                        case "1":
                            Console.Write("Raça: ");
                            var raca = Console.ReadLine();
                            Console.Write("Porte: ");
                            var porte = Console.ReadLine();
                            Console.Write("Temperamento: ");
                            var temperamento = Console.ReadLine();
                            novoAnimal = new Cachorro(nome, idade, peso, dono, raca, porte, temperamento);
                            break;
                        case "2":
                            Console.Write("Tipo de pelo: ");
                            var pelo = Console.ReadLine();
                            Console.Write("Comportamento: ");
                            var comportamento = Console.ReadLine();
                            novoAnimal = new Gato(nome, idade, peso, dono, pelo, comportamento);
                            break;
                        case "3":
                            Console.Write("Espécie: ");
                            var especie = Console.ReadLine();
                            Console.Write("Envergadura (cm): ");
                            double.TryParse(Console.ReadLine(), out double envergadura);
                            novoAnimal = new Passaro(nome, idade, peso, dono, especie, envergadura);
                            break;
                        default:
                            Console.WriteLine("Tipo inválido.");
                            break;
                    }
                    if (novoAnimal != null)
                    {
                        animais.Add(novoAnimal);
                        Console.WriteLine("Animal cadastrado com sucesso!");
                    }
                    break;

                case "3":
                    for (int i = 0; i < animais.Count; i++)
                    {
                        Console.WriteLine($"\nAnimal {i + 1}:");
                        animais[i].ExibirInfo();
                        Console.WriteLine("Serviços disponíveis:");
                        foreach (var servico in animais[i].ServicosDisponiveis())
                        {
                            Console.WriteLine($"- {servico}");
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