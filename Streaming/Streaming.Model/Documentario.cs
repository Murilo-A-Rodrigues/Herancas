using System;

namespace Streaming.Model
{
    public class Documentario : Midia
    {
        public string Tema { get; set; }
        public string Narrador { get; set; }

        public Documentario(string titulo, int duracao, string genero, string tema, string narrador)
            : base(titulo, duracao, genero)
        {
            Tema = tema;
            Narrador = narrador;
        }

        public override void ExibirResumo()
        {
            Console.WriteLine($"Documentário: {Titulo}");
            Console.WriteLine($"Tema: {Tema} | Narrador: {Narrador}");
            Console.WriteLine($"Gênero: {Genero} | Duração: {Duracao} min");
        }
    }
}