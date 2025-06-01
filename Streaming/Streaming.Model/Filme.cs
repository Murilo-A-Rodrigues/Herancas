using System;
using System.Collections.Generic;

namespace Streaming.Model
{
    public class Filme : Midia
    {
        public string Diretor { get; set; }
        public int Ano { get; set; }
        public List<string> Elenco { get; set; }

        public Filme(string titulo, int duracao, string genero, string diretor, int ano, List<string> elenco)
            : base(titulo, duracao, genero)
        {
            Diretor = diretor;
            Ano = ano;
            Elenco = elenco;
        }

        public override void ExibirResumo()
        {
            Console.WriteLine($"Filme: {Titulo} ({Ano})");
            Console.WriteLine($"Diretor: {Diretor}");
            Console.WriteLine($"Gênero: {Genero} | Duração: {Duracao} min");
            Console.WriteLine($"Elenco: {string.Join(", ", Elenco)}");
        }
    }
}