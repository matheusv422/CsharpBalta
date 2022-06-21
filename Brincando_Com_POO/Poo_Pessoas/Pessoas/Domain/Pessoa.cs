namespace Pessoas.Domain
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa()
        {
            this.Nome = "";
            this.Idade = 0;
        }
        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public void ExibirDados()
        {

            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"Idade: {this.Idade}");

        }
    }
}