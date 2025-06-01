using System.Collections.Generic;

namespace Cursos.Model
{
    public class Aluno
    {
        public string Nome { get; set; }
        public List<Matricula> Matriculas { get; } = new List<Matricula>();

        public Aluno(string nome)
        {
            Nome = nome;
        }
    }
}