namespace Vendas.Model
{
    public class Produto
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto(string codigo, string nome, decimal preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }
    }
}