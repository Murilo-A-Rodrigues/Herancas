namespace ControleTreino.Model
{
    public class Exercicio
    {
        public string Nome { get; set; }
        public int Series { get; set; }
        public int Repeticoes { get; set; }
        public decimal Peso { get; set; } 

        public Exercicio(string nome, int series, int repeticoes, decimal peso)
        {
            Nome = nome;
            Series = series;
            Repeticoes = repeticoes;
            Peso = peso;
        }

        public decimal CargaTotal()
        {
            return Series * Repeticoes * Peso;
        }
    }
}