using System;
using Recrutamento.Model;

class Program
{
    static void Main()
    {
        var candidato1 = new Candidato("Murilo Andre", "Murilo@gmail.com", "Cursando CC, estudando em C#");
        var candidato2 = new Candidato("Ilruom Garkran", "Gark@email.com", "Engenheiro de Software, Java, Python");

        var vaga1 = new Vaga("Desenvolvedor C#", "TechCorp", "Desenvolvimento de aplicações .NET");
        var vaga2 = new Vaga("Analista de Dados", "DataX", "Análise de grandes volumes de dados");

        var cand1Vaga1 = new Candidatura(candidato1, vaga1);
        var cand2Vaga1 = new Candidatura(candidato2, vaga1, "rejeitada");
        var cand1Vaga2 = new Candidatura(candidato1, vaga2, "aprovada");

        Console.WriteLine($"Vagas para as quais {candidato1.Nome} se candidatou:");
        foreach (var c in candidato1.Candidaturas)
        {
            Console.WriteLine($"- {c.Vaga.Titulo} ({c.Status}, enviada em {c.DataEnvio:dd/MM/yyyy})");
        }

        Console.WriteLine($"Vagas para as quais {candidato2.Nome} se candidatou:");
        foreach (var c in candidato2.Candidaturas)
        {
            Console.WriteLine($"- {c.Vaga.Titulo} ({c.Status}, enviada em {c.DataEnvio:dd/MM/yyyy})");
        }

        Console.WriteLine($"\nCandidatos para a vaga '{vaga1.Titulo}':");
        foreach (var c in vaga1.Candidaturas)
        {
            Console.WriteLine($"- {c.Candidato.Nome} ({c.Status}, {c.DataEnvio:dd/MM/yyyy})");
        }
        
        Console.WriteLine($"\nCandidatos para a vaga '{vaga2.Titulo}':");
        foreach (var c in vaga2.Candidaturas)
        {
            Console.WriteLine($"- {c.Candidato.Nome} ({c.Status}, {c.DataEnvio:dd/MM/yyyy})");
        }
    }
}