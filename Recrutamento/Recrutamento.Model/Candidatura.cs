using System;

namespace Recrutamento.Model
{
    public class Candidatura
    {
        public Candidato Candidato { get; }
        public Vaga Vaga { get; }
        public DateTime DataEnvio { get; }
        public string Status { get; set; }

        public Candidatura(Candidato candidato, Vaga vaga, string status = "em análise")
        {
            Candidato = candidato;
            Vaga = vaga;
            DataEnvio = DateTime.Now;
            Status = status;

            candidato.Candidaturas.Add(this);
            vaga.Candidaturas.Add(this);
        }
    }
}