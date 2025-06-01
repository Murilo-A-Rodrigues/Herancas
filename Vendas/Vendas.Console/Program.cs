using System;
using Vendas.Model;

class Program
{
    static void Main()
    {
        var produto1 = new Produto("001", "Box Pokemon TCG", 299.99m);
        var produto2 = new Produto("002", "Box Jurassic Park - Edição capa dura", 167.90m);

        var pedido = new Pedido();
        pedido.AdicionarItem(produto1, 2);
        pedido.AdicionarItem(produto2, 1);

        Console.WriteLine("Itens do pedido:");
        foreach (var item in pedido.Itens)
        {
            Console.WriteLine($"{item.Produto.Nome} - {item.Quantidade} x {item.Produto.Preco:C} = {item.Subtotal:C}");
        }
        Console.WriteLine($"Total do pedido: {pedido.Total:C}");
    }
}