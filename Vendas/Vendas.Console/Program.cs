﻿using System;
using System.Collections.Generic;
using Vendas.Model;

class Program
{
    static void Main()
    {
        var produtos = new List<Produto>();
        var pedido = new Pedido();

        while (true)
        {
            Console.WriteLine("\n--- MENU PRINCIPAL ---");
            Console.WriteLine("1. Menu de Produtos");
            Console.WriteLine("2. Menu de Pedidos");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            var opcao = Console.ReadLine();

            if (opcao == "0") break;

            switch (opcao)
            {
                case "1":
                    while (true)
                    {
                        Console.WriteLine("\n--- MENU DE PRODUTOS ---");
                        Console.WriteLine("1. Cadastrar novo produto");
                        Console.WriteLine("2. Listar produtos");
                        Console.WriteLine("0. Voltar");
                        Console.Write("Escolha uma opção: ");
                        var prodOpcao = Console.ReadLine();

                        if (prodOpcao == "0") break;

                        switch (prodOpcao)
                        {
                            case "1":
                                var codigo = (produtos.Count + 1).ToString("D3");
                                Console.Write("Nome do produto: ");
                                var nome = Console.ReadLine();
                                Console.Write("Preço do produto: ");
                                if (decimal.TryParse(Console.ReadLine(), out decimal preco) && preco > 0)
                                {
                                    produtos.Add(new Produto(codigo, nome, preco));
                                    Console.WriteLine($"Produto cadastrado com sucesso! Código gerado: {codigo}");
                                }
                                else
                                {
                                    Console.WriteLine("Preço inválido.");
                                }
                                break;
                            case "2":
                                if (produtos.Count == 0)
                                {
                                    Console.WriteLine("Nenhum produto cadastrado.");
                                }
                                else
                                {
                                    Console.WriteLine("\nProdutos cadastrados:");
                                    for (int i = 0; i < produtos.Count; i++)
                                        Console.WriteLine($"{i + 1}. {produtos[i].Nome} - {produtos[i].Preco:C}");
                                }
                                break;
                            default:
                                Console.WriteLine("Opção inválida.");
                                break;
                        }
                    }
                    break;

                case "2":
                    while (true)
                    {
                        Console.WriteLine("\n--- MENU DE PEDIDOS ---");
                        Console.WriteLine("1. Adicionar item ao pedido");
                        Console.WriteLine("2. Ver itens do pedido");
                        Console.WriteLine("3. Ver total do pedido");
                        Console.WriteLine("0. Voltar");
                        Console.Write("Escolha uma opção: ");
                        var pedOpcao = Console.ReadLine();

                        if (pedOpcao == "0") break;

                        switch (pedOpcao)
                        {
                            case "1":
                                if (produtos.Count == 0)
                                {
                                    Console.WriteLine("Nenhum produto cadastrado. Cadastre produtos primeiro.");
                                    break;
                                }
                                Console.WriteLine("\nProdutos disponíveis:");
                                for (int i = 0; i < produtos.Count; i++)
                                    Console.WriteLine($"{i + 1}. {produtos[i].Nome} - {produtos[i].Preco:C}");
                                Console.Write("Digite o número do produto: ");
                                if (int.TryParse(Console.ReadLine(), out int prodIndex) && prodIndex > 0 && prodIndex <= produtos.Count)
                                {
                                    Console.Write("Quantidade: ");
                                    if (int.TryParse(Console.ReadLine(), out int qtd) && qtd > 0)
                                    {
                                        pedido.AdicionarItem(produtos[prodIndex - 1], qtd);
                                        Console.WriteLine("Item adicionado!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Quantidade inválida.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Produto inválido.");
                                }
                                break;
                            case "2":
                                if (pedido.Itens.Count == 0)
                                {
                                    Console.WriteLine("Nenhum item no pedido.");
                                }
                                else
                                {
                                    Console.WriteLine("\nItens do pedido:");
                                    foreach (var item in pedido.Itens)
                                    {
                                        Console.WriteLine($"{item.Produto.Nome} - {item.Quantidade} x {item.Produto.Preco:C} = {item.Subtotal:C}");
                                    }
                                }
                                break;
                            case "3":
                                Console.WriteLine($"\nTotal do pedido: {pedido.Total:C}");
                                break;
                            default:
                                Console.WriteLine("Opção inválida.");
                                break;
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