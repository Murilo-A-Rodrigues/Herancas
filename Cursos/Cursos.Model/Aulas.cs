namespace Cursos.Model
{
    public class Aula
    {
        public string Titulo { get; set; }
        public int DuracaoMinutos { get; set; }
        public Professor ProfessorResponsavel { get; set; }

        public Aula(string titulo, int duracaoMinutos, Professor professor)
        {
            Titulo = titulo;
            DuracaoMinutos = duracaoMinutos;
            ProfessorResponsavel = professor;
        }
    }
}