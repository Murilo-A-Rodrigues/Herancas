using System.Collections.Generic;

namespace Recrutamento.Model
{
    public class Candidato
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Curriculo { get; set; }
        public List<Candidatura> Candidaturas { get; } = new List<Candidatura>();

        public Candidato(string nome, string email, string curriculo)
        {
            Nome = nome;
            Email = email;
            Curriculo = curriculo;
        }
    }
}