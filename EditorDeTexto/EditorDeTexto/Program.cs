using System;
using System.IO;

namespace EditorDeTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Selecione a opção que você deseja executar: ");
            Console.WriteLine("1 - Abrir Arquivo");
            Console.WriteLine("2 - Editar Arquivo");
            Console.WriteLine("0 - Sair");

            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    AbrirArquivo();
                    break;
                case 2:
                    EditarArquivo();
                    break;
            }
        }
        static void AbrirArquivo()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do  arquivo que você deseja abrir?");
            string caminho = Console.ReadLine();

            using (var arquivo = new StreamReader(caminho))
            {
                string texto = arquivo.ReadToEnd();
                Console.WriteLine(texto);
            }

            Console.WriteLine("");
            Console.ReadLine();

        }

        static void EditarArquivo()
        {
            Console.Clear();
            Console.WriteLine("Digite o seu texto abaixo");
            Console.WriteLine("--------------");

            string texto = "";

            do
            {
                texto += Console.ReadLine();
                texto += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            SalvarArquivo(texto);
            Console.Clear();

            Console.Write(texto);
        }

        static void SalvarArquivo(string texto)
        {
            Console.Clear();
            Console.WriteLine("Onde você deseja salvar o seu arquivo?");
            var caminho = Console.ReadLine();

            using (var arquivo = new StreamWriter(caminho))
            {
                arquivo.Write(texto);
            }

            Console.WriteLine($"Seu arquivo foi salvo com sucesso em '{caminho}' !");
            Console.ReadLine();
        }
    }
}
