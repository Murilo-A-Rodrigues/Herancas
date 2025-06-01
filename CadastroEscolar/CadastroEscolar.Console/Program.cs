using System;
using System.Collections.Generic;
using CadastroEscolar.Model;

class Program
{
    static void Main()
    {
        var pessoas = new List<Pessoa>
        {
            new Aluno("Ilruom", "590.777.937-66", DateTime.ParseExact("27/03/2006", "dd/MM/yyyy", null), "A001", "1A"),
            new Professor("Garkran", "987.654.321-00", DateTime.ParseExact("31/05/1980", "dd/MM/yyyy", null), new List<string> { "Matemática", "Física" }),
            new Funcionario("Livnad", "111.222.333-44", DateTime.ParseExact("05/10/1995", "dd/MM/yyyy", null), "Secretaria")
        };

        foreach (var pessoa in pessoas)
        {
            pessoa.ExibirDados();
            Console.WriteLine();
        }
    }
}