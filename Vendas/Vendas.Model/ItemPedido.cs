namespace Vendas.Model
{
    public class ItemPedido
    {
        public Produto Produto { get; }
        public int Quantidade { get; }
        public decimal Subtotal => Produto.Preco * Quantidade;

        public ItemPedido(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        }
    }
}