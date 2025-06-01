using System;

namespace Veiculos.Model
{
    public class Manutencao
    {
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; } 

        public Manutencao(DateTime data, string descricao, string tipo)
        {
            Data = data;
            Descricao = descricao;
            Tipo = tipo;
        }
    }
}