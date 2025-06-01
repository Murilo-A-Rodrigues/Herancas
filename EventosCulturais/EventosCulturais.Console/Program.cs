using System;
using System.Collections.Generic;
using EventosCulturais.Model;

class Program
{
    static void Main()
    {
        var oficina = new Oficina(
            "Competição de Speed Run",
            DateTime.ParseExact("15/06/2024", "dd/MM/yyyy", null),
            "14:00", "Sala 1", 10, "Controle", 8);

        var palestra = new Palestra(
            "Inovação Cultural",
            DateTime.ParseExact("12/06/2024", "dd/MM/yyyy", null),
            "19:00", "Auditório", 100, "Dr. Antonio", "Cultura Digital", 75);

        var show = new Show(
            "Rock Night",
            DateTime.ParseExact("25/06/2024", "dd/MM/yyyy", null),
            "21:00", "Palco Principal", 500, "Imagine Dragons", "Rock", "16+");

        var participante1 = new Participante("Murilo", "murilo@gmail.com");
        var participante2 = new Participante("Argon", "Argon@gmail.com");

        participante1.Inscrever(oficina);
        participante1.Inscrever(show);
        participante2.Inscrever(palestra);
        participante2.Inscrever(show);

        var eventos = new List<Evento> { oficina, palestra, show };

        foreach (var evento in eventos)
        {
            evento.ExibirInformacoes();
            Console.WriteLine("Participantes:");
            foreach (var p in evento.Participantes)
            {
                Console.WriteLine($"- {p.Nome} ({p.Email})");
            }
            Console.WriteLine();
        }
    }
}