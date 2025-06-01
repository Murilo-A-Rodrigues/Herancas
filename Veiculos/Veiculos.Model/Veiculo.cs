using System;
using System.Collections.Generic;
using System.Linq;

namespace Veiculos.Model
{
    public class Veiculo
    {
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; } // Ex: passeio, utilitário, etc.

        private List<Manutencao> manutencoes = new List<Manutencao>();
        public IReadOnlyList<Manutencao> Manutencoes => manutencoes.AsReadOnly();

        public Veiculo(string modelo, string placa, string tipo)
        {
            Modelo = modelo;
            Placa = placa;
            Tipo = tipo;
        }

        public void AdicionarManutencao(Manutencao manutencao)
        {
            if (manutencoes.Any(m => m.Data.Date == manutencao.Data.Date))
                throw new InvalidOperationException($"Já existe uma manutenção registrada para {manutencao.Data:dd/MM/yyyy}.");
            manutencoes.Add(manutencao);
        }
    }
}