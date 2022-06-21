using Pessoas.Domain;
using Pessoas.Messages;

namespace Pessoas.Service
{
    public class Business
    {
        public void DescobrirPessoaMaisVelha()
        {
            var pessoa1 = new Pessoa();
            var pessoa2 = new Pessoa();
            var pessoa3 = new Pessoa();
            var mensagens = new Mensagens();


            mensagens.InformePrimeiraPessoa();

            try
            {
                Console.WriteLine("Nome: ");
                pessoa1.Nome = Console.ReadLine();

                Console.WriteLine("Idade: ");
                pessoa2.Idade = int.Parse(Console.ReadLine());
                Console.Clear();
                mensagens.InformeSegundaPessoa();

                Console.WriteLine("Nome: ");
                pessoa2.Nome = Console.ReadLine();

                Console.WriteLine("Idade: ");
                pessoa1.Idade = int.Parse(Console.ReadLine());
                Console.Clear();
                mensagens.InformeTerceiraPessoa();

                Console.WriteLine("Nome: ");
                pessoa3.Nome = Console.ReadLine();

                System.Console.WriteLine("Idade: ");
                pessoa3.Idade = int.Parse(Console.ReadLine());
                Console.Clear();
                // if (pessoa1.Idade > pessoa2.Idade && pessoa1.Idade > pessoa3.Idade){
                //     Console.WriteLine("A pessoa mais velha é: ");
                //     pessoa1.ExibirDados();
                // }
            }

            catch(Exception)
            {
                throw new Exception(mensagens.MensagemCampoInvalido());
            }

            var listaDeIdades = new List<int>();

            listaDeIdades.Add(pessoa1.Idade);
            listaDeIdades.Add(pessoa2.Idade);
            listaDeIdades.Add(pessoa3.Idade);

            var pessoaMaisVelha = listaDeIdades.Max();

            var idadesIdenticas = VerificaIdadesIguais(listaDeIdades);

             if (idadesIdenticas)
            {
                mensagens.IdadesIguais();
            }

            else if (pessoaMaisVelha == pessoa1.Idade)
            {
                mensagens.PessoaMaisVelha();
                pessoa1.ExibirDados();
            }
            else if (pessoaMaisVelha == pessoa2.Idade)
            {
                mensagens.PessoaMaisVelha();
                pessoa2.ExibirDados();
            }

            else if (pessoaMaisVelha == pessoa3.Idade)
            {
                mensagens.PessoaMaisVelha();
                pessoa3.ExibirDados();

            }

            else
            {
                mensagens.IdadesNulasOuVazias();
            }


        }

        public bool VerificaIdadesIguais(List<int> idades)
        {
            bool idadesSaoIguais = !idades.Any( i => i != idades.FirstOrDefault());

            return idadesSaoIguais;
        }
    }
}