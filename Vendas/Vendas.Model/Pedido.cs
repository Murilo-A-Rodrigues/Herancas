using System.Collections.Generic;
using System.Linq;

namespace Vendas.Model
{
    public class Pedido
    {
        private List<ItemPedido> itens = new List<ItemPedido>();
        public IReadOnlyList<ItemPedido> Itens => itens.AsReadOnly();

        public decimal Total => itens.Sum(item => item.Subtotal);

        public void AdicionarItem(Produto produto, int quantidade)
        {
            itens.Add(new ItemPedido(produto, quantidade));
        }

        public void RemoverItem(ItemPedido item)
        {
            itens.Remove(item);
        }
    }
}