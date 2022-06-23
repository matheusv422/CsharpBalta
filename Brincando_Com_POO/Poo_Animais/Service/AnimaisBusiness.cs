using Poo_Animais.Models;

namespace Poo_Animais.Service
{
    public class AnimaisBusiness
    {
        public AnimaisBusiness()
        {

        }

        public void ExecutarPrograma()
        {
            try
            {
            var animal1 = new Animais();
            var animal2 = new Animais();
            var animal3 = new Animais();
            var animal4 = new Animais();
            var animal5 = new Animais();

            Console.WriteLine("Olá, digite o nome do seu animal de estimação: ");

            animal1.NomeDoAnimal = Console.ReadLine();

            Console.WriteLine("Agora digite o número do tipo que ele representa: ");
            Console.WriteLine(" 1 = Cachorro");
            Console.WriteLine(" 2 = Gato");
            Console.WriteLine(" 3 = Peixe");
            Console.WriteLine("Obs: Qualquer outro número além desses 3 irão representar o tipo 'Peixe'");
            animal1.TipoDeAnimal = Convert.ToByte(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Agora digite o nome do segundo animal de estimação: ");

            animal2.NomeDoAnimal = Console.ReadLine();

            System.Console.WriteLine("Agora digite o número do tipo que ele representa: ");
            System.Console.WriteLine(" 1 = Cachorro");
            System.Console.WriteLine(" 2 = Gato");
            System.Console.WriteLine(" 3 = Peixe");
            System.Console.WriteLine("Obs: Qualquer outro número além desses 3 irão representar o tipo 'Peixe'");
            animal2.TipoDeAnimal = Convert.ToByte(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Agora digite o nome do terceiro animal de estimação: ");

            animal3.NomeDoAnimal = Console.ReadLine();

            System.Console.WriteLine("Agora digite o número do tipo que ele representa: ");
            System.Console.WriteLine(" 1 = Cachorro");
            System.Console.WriteLine(" 2 = Gato");
            System.Console.WriteLine(" 3 = Peixe");
            System.Console.WriteLine("Obs: Qualquer outro número além desses 3 irão representar o tipo 'Peixe'");
            animal3.TipoDeAnimal = Convert.ToByte(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Agora digite o nome do quarto animal de estimação: ");

            animal4.NomeDoAnimal = Console.ReadLine();

            System.Console.WriteLine("Agora digite o número do tipo que ele representa: ");
            System.Console.WriteLine(" 1 = Cachorro");
            System.Console.WriteLine(" 2 = Gato");
            System.Console.WriteLine(" 3 = Peixe");
            System.Console.WriteLine("Obs: Qualquer outro número além desses 3 irão representar o tipo 'Peixe'");
            animal4.TipoDeAnimal = Convert.ToByte(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Agora digite o nome do quinto e ultimo animal de estimação: ");

            animal5.NomeDoAnimal = Console.ReadLine();

            Console.WriteLine("Agora digite o número do tipo que ele representa: ");
            Console.WriteLine(" 1 = Cachorro");
            Console.WriteLine(" 2 = Gato");
            Console.WriteLine(" 3 = Peixe");
            Console.WriteLine("Obs: Qualquer outro número além desses 3 irão representar o tipo 'Peixe'");
            animal5.TipoDeAnimal = Convert.ToByte(Console.ReadLine());
            Console.Clear();

            var listaTiposAnimais = new List<byte>();

            listaTiposAnimais.Add(animal1.TipoDeAnimal);
            listaTiposAnimais.Add(animal2.TipoDeAnimal);
            listaTiposAnimais.Add(animal3.TipoDeAnimal);
            listaTiposAnimais.Add(animal4.TipoDeAnimal);
            listaTiposAnimais.Add(animal5.TipoDeAnimal);

            ContabilizaTipoAnimal(listaTiposAnimais);
                
            }
            catch (Exception ex)
            { throw new Exception("Você digitou um dado inválido", ex);
            }
        }

        public void ContabilizaTipoAnimal(List<byte> listaTiposAnimais)
        {
            var cachorros = listaTiposAnimais.Count(x => x == 1);
            var gatos = listaTiposAnimais.Count(x => x == 2);
            var peixes = listaTiposAnimais.Count(x => x == 3 || (x != 1 && x != 2 && x != 3));

            Console.WriteLine($"Foram informados {cachorros} cachorro(s), {gatos} gato(s) e {peixes} peixe(s) durante a execução do programa!");
        }


    }
}