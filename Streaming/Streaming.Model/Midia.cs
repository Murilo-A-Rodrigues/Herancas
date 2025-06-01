namespace Streaming.Model
{
    public abstract class Midia
    {
        public string Titulo { get; set; }
        public int Duracao { get; set; } 
        public string Genero { get; set; }

        protected Midia(string titulo, int duracao, string genero)
        {
            Titulo = titulo;
            Duracao = duracao;
            Genero = genero;
        }

        public abstract void ExibirResumo();
    }
}