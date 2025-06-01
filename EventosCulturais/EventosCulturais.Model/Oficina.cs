using System;

namespace EventosCulturais.Model
{
    public class Oficina : Evento
    {
        public string MaterialNecessario { get; set; }
        public int NumeroMaximoParticipantes { get; set; }

        public Oficina(string titulo, DateTime data, string horario, string local, int capacidade, string material, int maxParticipantes)
            : base(titulo, data, horario, local, capacidade)
        {
            MaterialNecessario = material;
            NumeroMaximoParticipantes = maxParticipantes;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Oficina: {Titulo} ({Data:dd/MM/yyyy} às {Horario})");
            Console.WriteLine($"Local: {Local} | Capacidade: {Capacidade}");
            Console.WriteLine($"Material necessário: {MaterialNecessario} | Máx. participantes: {NumeroMaximoParticipantes}");
        }
    }
}