using System;
using System.Collections.Generic;

namespace EventosCulturais.Model
{
    public abstract class Evento
    {
        public string Titulo { get; set; }
        public DateTime Data { get; set; }
        public string Horario { get; set; }
        public string Local { get; set; }
        public int Capacidade { get; set; }
        public List<Participante> Participantes { get; } = new List<Participante>();

        protected Evento(string titulo, DateTime data, string horario, string local, int capacidade)
        {
            Titulo = titulo;
            Data = data;
            Horario = horario;
            Local = local;
            Capacidade = capacidade;
        }

        public abstract void ExibirInformacoes();
    }
}