using System;
using System.Collections.Generic;
using PetShop.Model;

class Program
{
    static void Main()
    {
        var dono1 = new Dono("Nero", "99999-0000");
        var dono2 = new Dono("Tiana", "88888-1111");

        var cachorro = new Cachorro("Dortch", 5, 20.5, dono1, "Labrador", "Grande", "Amigável");
        var gato = new Gato("Nix", 3, 4.2, dono2, "Curta", "Independente");
        var passaro = new Passaro("Donald", 1, 0.3, dono1, "Canário", 15.0);

        var animais = new List<Animal> { cachorro, gato, passaro };

        foreach (var animal in animais)
        {
            animal.ExibirInfo();
            Console.WriteLine("Serviços disponíveis para este animal:");
            foreach (var servico in animal.ServicosDisponiveis())
            {
                Console.WriteLine($"- {servico}");
            }
            Console.WriteLine();
        }
    }
}