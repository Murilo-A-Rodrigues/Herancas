using System;
using System.Collections.Generic;

namespace PetShop.Model
{
    public class Cachorro : Animal
    {
        public string Raca { get; set; }
        public string Porte { get; set; }
        public string Temperamento { get; set; }

        public Cachorro(string nome, int idade, double peso, Dono dono, string raca, string porte, string temperamento)
            : base(nome, idade, peso, dono)
        {
            Raca = raca;
            Porte = porte;
            Temperamento = temperamento;
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Cachorro - Raça: {Raca}, Porte: {Porte}, Temperamento: {Temperamento}");
        }

        public void BanhoETosa()
        {
            Console.WriteLine($"{Nome} está tomando banho e tosa!");
        }

        public override List<string> ServicosDisponiveis()
        {
            var servicos = base.ServicosDisponiveis();
            servicos.Add("Banho e tosa");
            servicos.Add("Adestramento");
            return servicos;
        }
    }
}