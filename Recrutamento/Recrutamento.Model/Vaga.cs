using System.Collections.Generic;

namespace Recrutamento.Model
{
    public class Vaga
    {
        public string Titulo { get; set; }
        public string Empresa { get; set; }
        public string Descricao { get; set; }
        public List<Candidatura> Candidaturas { get; } = new List<Candidatura>();

        public Vaga(string titulo, string empresa, string descricao)
        {
            Titulo = titulo;
            Empresa = empresa;
            Descricao = descricao;
        }
    }
}