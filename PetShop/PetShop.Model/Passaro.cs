using System;
using System.Collections.Generic;

namespace PetShop.Model
{
    public class Passaro : Animal
    {
        public string Especie { get; set; }
        public double Envergadura { get; set; }

        public Passaro(string nome, int idade, double peso, Dono dono, string especie, double envergadura)
            : base(nome, idade, peso, dono)
        {
            Especie = especie;
            Envergadura = envergadura;
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Pássaro - Espécie: {Especie}, Envergadura: {Envergadura}cm");
        }

        public override List<string> ServicosDisponiveis()
        {
            var servicos = base.ServicosDisponiveis();
            servicos.Add("Limpeza de gaiola");
            return servicos;
        }
    }
}