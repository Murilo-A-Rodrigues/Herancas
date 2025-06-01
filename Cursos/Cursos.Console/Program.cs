using System;
using System.Collections.Generic;
using Cursos.Model;

class Program
{
    static void Main()
    {
        var prof1 = new Professor("John");
        var curso = new Curso("C# Básico");
        curso.AdicionarAula(new Aula("Introdução", 30, prof1));

        var aluno1 = new Aluno("Murilo");
        var aluno2 = new Aluno("Elirian");

        var matricula1 = new Matricula(aluno1, curso) { Progresso = 0.5 }; 
        var matricula2 = new Matricula(aluno2, curso) { Progresso = 0.1 }; 

        aluno1.Matriculas.Add(matricula1);
        aluno2.Matriculas.Add(matricula2);

        foreach (var matricula in new List<Matricula> { matricula1, matricula2 })
        {
            Console.WriteLine($"{matricula.Aluno.Nome} - Curso: {matricula.Curso.Nome} - Progresso: {matricula.Progresso:P0}");
        }
    }
}