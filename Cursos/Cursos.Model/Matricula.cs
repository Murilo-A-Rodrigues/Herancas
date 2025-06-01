using System;

namespace Cursos.Model
{
    public class Matricula
    {
        public Aluno Aluno { get; }
        public Curso Curso { get; }
        public DateTime DataInscricao { get; }
        public double Progresso { get; set; } 

        public Matricula(Aluno aluno, Curso curso)
        {
            Aluno = aluno;
            Curso = curso;
            DataInscricao = DateTime.Now;
            Progresso = 0.0;
        }
    }
}