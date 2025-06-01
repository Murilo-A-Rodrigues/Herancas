using System;
using System.Collections.Generic;

namespace PetShop.Model
{
    public abstract class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }
        public Dono Dono { get; set; }

        protected Animal(string nome, int idade, double peso, Dono dono)
        {
            Nome = nome;
            Idade = idade;
            Peso = peso;
            Dono = dono;
        }

        public virtual void ExibirInfo()
        {
            Console.WriteLine($"Animal: {Nome}, Idade: {Idade}, Peso: {Peso}kg, Dono: {Dono?.Nome}");
        }

        public virtual List<string> ServicosDisponiveis()
        {
            return new List<string> { "Consulta veterinária", "Vacinação" };
        }
    }
}