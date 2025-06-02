using System;
using Veiculos.Model;

class Program
{
    static void Main()
    {
        Console.Write("Modelo do veículo: ");
        var modelo = Console.ReadLine();
        Console.Write("Placa do veículo: ");
        var placa = Console.ReadLine();
        Console.Write("Tipo do veículo: ");
        var tipo = Console.ReadLine();

        var veiculo = new Veiculo(modelo, placa, tipo);

        while (true)
        {
            Console.WriteLine("\n--- MENU VEÍCULO ---");
            Console.WriteLine("1. Adicionar manutenção");
            Console.WriteLine("2. Ver histórico de manutenções");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            var opcao = Console.ReadLine();

            if (opcao == "0") break;

            switch (opcao)
            {
                case "1":
                    try
                    {
                        Console.Write("Data da manutenção (dd/MM/yyyy): ");
                        var dataStr = Console.ReadLine();
                        if (!DateTime.TryParseExact(dataStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime data))
                        {
                            Console.WriteLine("Data inválida! Use o formato dd/MM/yyyy ou verifique se a data foi digitada corretamente.");
                            break;
                        }
                        if (data > DateTime.Now)
                        {
                            Console.WriteLine("A data da manutenção não pode ser no futuro.");
                            break;
                        }

                        Console.Write("Descrição: ");
                        var descricao = Console.ReadLine();
                        Console.Write("Tipo (Preventiva/Corretiva): ");
                        var tipoManut = Console.ReadLine();

                        var manut = new Manutencao(data, descricao, tipoManut);
                        veiculo.AdicionarManutencao(manut);
                        Console.WriteLine("Manutenção adicionada com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro ao adicionar manutenção: {ex.Message}");
                    }
                    break;

                case "2":
                    Console.WriteLine("\nHistórico de manutenções:");
                    if (veiculo.Manutencoes.Count == 0)
                    {
                        Console.WriteLine("Nenhuma manutenção registrada.");
                    }
                    else
                    {
                        foreach (var manu in veiculo.Manutencoes)
                        {
                            Console.WriteLine($"{manu.Data:dd/MM/yyyy} - {manu.Tipo} - {manu.Descricao}");
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