using System.Collections.Generic;

namespace EventosCulturais.Model
{
    public class Participante
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public List<Evento> EventosInscritos { get; } = new List<Evento>();

        public Participante(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public void Inscrever(Evento evento)
        {
            if (!EventosInscritos.Contains(evento) && evento.Participantes.Count < evento.Capacidade)
            {
                EventosInscritos.Add(evento);
                evento.Participantes.Add(this);
            }
        }
    }
}