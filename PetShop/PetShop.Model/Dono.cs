namespace PetShop.Model
{
    public class Dono
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Dono(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }
    }
}