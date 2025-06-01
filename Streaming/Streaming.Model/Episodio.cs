namespace Streaming.Model
{
    public class Episodio
    {
        public string Titulo { get; set; }
        public int Duracao { get; set; } 

        public Episodio(string titulo, int duracao)
        {
            Titulo = titulo;
            Duracao = duracao;
        }
    }
}