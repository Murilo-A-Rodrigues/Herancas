using System;

namespace EventosCulturais.Model
{
    public class Show : Evento
    {
        public string BandaOuArtista { get; set; }
        public string EstiloMusical { get; set; }
        public string ClassificacaoEtaria { get; set; }

        public Show(string titulo, DateTime data, string horario, string local, int capacidade, string artista, string estilo, string classificacao)
            : base(titulo, data, horario, local, capacidade)
        {
            BandaOuArtista = artista;
            EstiloMusical = estilo;
            ClassificacaoEtaria = classificacao;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Show: {Titulo} ({Data:dd/MM/yyyy} às {Horario})");
            Console.WriteLine($"Local: {Local} | Capacidade: {Capacidade}");
            Console.WriteLine($"Artista/Banda: {BandaOuArtista} | Estilo: {EstiloMusical} | Classificação: {ClassificacaoEtaria}");
        }
    }
}