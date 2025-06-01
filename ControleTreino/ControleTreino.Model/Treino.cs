using System;
using System.Collections.Generic;
using System.Linq;

namespace ControleTreino.Model
{
    public class Treino
    {
        public DateTime DataCriacao { get; set; }
        public string Objetivo { get; set; }
        public string Tipo { get; set; } 
        public List<Exercicio> Exercicios { get; } = new List<Exercicio>();

        public Treino(DateTime dataCriacao, string objetivo, string tipo)
        {
            DataCriacao = dataCriacao;
            Objetivo = objetivo;
            Tipo = tipo;
        }

        public decimal CargaTotal()
        {
            return Exercicios.Sum(e => e.CargaTotal());
        }
    }
}