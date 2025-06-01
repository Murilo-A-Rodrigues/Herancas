using System;
using ControleTreino.Model;

class Program
{
    static void Main()
    {
        var aluno = new Aluno("Ilruom", 21, "Hipertrofia", "Altura: 1,90m; Peso: 95kg");

        var treino = new Treino(DateTime.Now, "Hipertrofia", "Superior");
        treino.Exercicios.Add(new Exercicio("Supino Reto", 4, 10, 60));
        treino.Exercicios.Add(new Exercicio("Remada Curvada", 4, 12, 40));
        treino.Exercicios.Add(new Exercicio("Desenvolvimento", 3, 10, 30));

        aluno.Treinos.Add(treino);

        treino.Exercicios[0].Series = 10;
        treino.Exercicios[1].Repeticoes = 15;
        treino.Exercicios[2].Peso = 65;

        Console.WriteLine($"Aluno: {aluno.Nome} | Objetivo: {aluno.Objetivo}");
        Console.WriteLine($"Treino: {treino.Tipo} ({treino.Objetivo}) - {treino.DataCriacao:dd/MM/yyyy}");
        foreach (var ex in treino.Exercicios)
        {
            Console.WriteLine($"- {ex.Nome}: {ex.Series}x{ex.Repeticoes} com {ex.Peso}kg (Carga total: {ex.CargaTotal()}kg)");
        }
        Console.WriteLine($"Carga total do treino: {treino.CargaTotal()}kg");
    }
}