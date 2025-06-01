using System.Collections.Generic;

namespace ControleTreino.Model
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Objetivo { get; set; }
        public string MedidasCorporais { get; set; }
        public List<Treino> Treinos { get; } = new List<Treino>();

        public Aluno(string nome, int idade, string objetivo, string medidas)
        {
            Nome = nome;
            Idade = idade;
            Objetivo = objetivo;
            MedidasCorporais = medidas;
        }
    }
}