using System.Collections.Generic;

namespace Cursos.Model
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Aula> Aulas { get; } = new List<Aula>();

        public Curso(string nome)
        {
            Nome = nome;
        }

        public void AdicionarAula(Aula aula)
        {
            Aulas.Add(aula);
        }
    }
}