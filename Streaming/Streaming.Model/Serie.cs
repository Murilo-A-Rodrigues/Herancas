using System;
using System.Collections.Generic;

namespace Streaming.Model
{
    public class Serie : Midia
    {
        public int Temporadas { get; set; }
        public int NumeroEpisodios => Episodios.Count;
        public List<Episodio> Episodios { get; set; } = new List<Episodio>();

        public Serie(string titulo, int duracao, string genero, int temporadas)
            : base(titulo, duracao, genero)
        {
            Temporadas = temporadas;
        }

        public void AdicionarEpisodio(Episodio episodio)
        {
            Episodios.Add(episodio);
        }

        public override void ExibirResumo()
        {
            Console.WriteLine($"Série: {Titulo}");
            Console.WriteLine($"Temporadas: {Temporadas} | Episódios: {NumeroEpisodios}");
            Console.WriteLine($"Gênero: {Genero} | Duração total: {Duracao} min");
            Console.WriteLine("Episódios:");
            foreach (var ep in Episodios)
            {
                Console.WriteLine($"- {ep.Titulo} ({ep.Duracao} min)");
            }
        }
    }
}