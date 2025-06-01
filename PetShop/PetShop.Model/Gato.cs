using System;
using System.Collections.Generic;

namespace PetShop.Model
{
    public class Gato : Animal
    {
        public string Pelagem { get; set; }
        public string Comportamento { get; set; }

        public Gato(string nome, int idade, double peso, Dono dono, string pelagem, string comportamento)
            : base(nome, idade, peso, dono)
        {
            Pelagem = pelagem;
            Comportamento = comportamento;
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Gato - Pelagem: {Pelagem}, Comportamento: {Comportamento}");
        }

        public override List<string> ServicosDisponiveis()
        {
            var servicos = base.ServicosDisponiveis();
            servicos.Add("Banho");
            servicos.Add("Corte de unhas");
            return servicos;
        }
    }
}