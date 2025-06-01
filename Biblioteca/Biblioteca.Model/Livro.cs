namespace Biblioteca.Model
{
    public class Livro
    {
        public string Titulo { get; }
        public string Autor { get; }
        public bool Disponivel { get; private set; } = true;

        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }

        public void Emprestar()
        {
            if (!Disponivel)
                throw new InvalidOperationException($"O livro '{Titulo}' já está emprestado.");
            Disponivel = false;
        }

        public void Devolver()
        {
            Disponivel = true;
        }
    }
}