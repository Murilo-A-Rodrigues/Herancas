using System;
using System.Collections.Generic;
using Streaming.Model;

class Program
{
    static void Main()
    {
        var filme = new Filme(
            "Godzilla II: Rei dos Monstros", 126, "Ficção Científica, Ação", "Michael Dougherty", 2019,
            new List<string> { "Charles Dance, Millie Bobby Brown, Vera Farmiga, Bradley Whitford, Kyle Chandler" }
        );

        var serie = new Serie("Sobrenatural", 13499, "Suspense", 15);
        serie.AdicionarEpisodio(new Episodio("T1 EP.1 – Piloto", 46));
        serie.AdicionarEpisodio(new Episodio("T1 EP.2 – Wendigo", 43));

        var doc = new Documentario("Planeta Terra", 60, "Natureza", "Vida Selvagem", "David Attenborough");

        var catalogo = new List<Midia> { filme, serie, doc };

        foreach (var midia in catalogo)
        {
            midia.ExibirResumo();
            Console.WriteLine();
        }
    }
}