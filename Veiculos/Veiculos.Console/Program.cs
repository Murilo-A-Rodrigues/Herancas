using System;
using Veiculos.Model;

class Program
{
    static void Main()
    {
        var veiculo = new Veiculo("Fiat Uno", "ABC-1234", "Passeio");

        var manut1 = new Manutencao(DateTime.ParseExact("01/06/2024", "dd/MM/yyyy", null), "Troca de óleo", "Preventiva");
        var manut2 = new Manutencao(DateTime.ParseExact("01/06/2024", "dd/MM/yyyy", null), "Alinhamento", "Corretiva");
        var manut3 = new Manutencao(DateTime.ParseExact("02/06/2024", "dd/MM/yyyy", null), "Revisão dos freios", "Preventiva");

        foreach (var manu in new[] { manut1, manut2, manut3 })
        {
            try
            {
                veiculo.AdicionarManutencao(manu);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        Console.WriteLine("\nHistórico de manutenções:");
        foreach (var manu in veiculo.Manutencoes)
        {
            Console.WriteLine($"{manu.Data:dd/MM/yyyy} - {manu.Tipo} - {manu.Descricao}");
        }
    }
}