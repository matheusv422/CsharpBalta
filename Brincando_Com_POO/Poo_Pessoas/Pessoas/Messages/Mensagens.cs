namespace Pessoas.Messages
{
   public class Mensagens
{
    public Mensagens()
    {

    }
    public void PessoaMaisVelha()
    {
        Console.WriteLine("A pessoa mais velha é: ");
    }
    public void InformePrimeiraPessoa()
    {
        Console.WriteLine("Digite o nome da primeira pessoa e sua idade respectivamente: ");
    }
    public void InformeSegundaPessoa()
    {
        Console.WriteLine("Digite o nome da segunda pessoa e sua idade respectivamente: ");
    }
    public void InformeTerceiraPessoa()
    {
        Console.WriteLine("Digite o nome da terceira pessoa e sua idade respectivamente: ");
    }

    public void IdadesNulasOuVazias(){
        Console.WriteLine("Não há idades para serem comparadas.");
    }

    public void IdadesIguais(){
        Console.WriteLine("Todas as idades informadas são iguais!");
    }

        public string MensagemCampoInvalido()
        {
            var mensagemDeErro = "O valor inserido em algum dos campos é nulo ou possui um tipo" +
                " diferente do requisitado.";
            return mensagemDeErro;
        }
}
}