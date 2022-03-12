using System;
using System.Globalization;

namespace CalculatorS
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor para somar: ");
            double v1 = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Segundo valor para somar: ");
            double v2 = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");

            var resultado = v1 + v2;

            Console.WriteLine($"O resultado da subtração é: {Math.Round(resultado)}");

            Console.ReadKey();
            Menu();

        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor para subtrair: ");
            double v1 = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Segundo valor para subtrair: ");
            double v2 = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");

            var resultado = v1 - v2;

            Console.WriteLine($"O resultado da subtracao é: {Math.Round(resultado)}");

            Console.ReadKey();
            Menu();

        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor para dividir: ");
            double v1 = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Segundo valor para dividir: ");
            double v2 = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");

            var resultado = v1 / v2;

            Console.WriteLine($"O resultado da divisão é: {Math.Round(resultado)}");

            Console.ReadKey();
            Menu();

        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor para multiplicar: ");
            double v1 = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Segundo valor multiplicar: ");
            double v2 = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");

            var resultado = v1 * v2;

            Console.WriteLine($"O resultado da multiplicação é: {Math.Round(resultado)}");

            Console.ReadKey();
            Menu();

        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Olá, selecione uma opção: ");
            Console.WriteLine("1 - Soma ");
            Console.WriteLine("2 - Subtração ");
            Console.WriteLine("3 - Multiplicação ");
            Console.WriteLine("4 - Divisão ");
            Console.WriteLine("5 - Sair ");

            Console.WriteLine("Selecione uma opção: ");

            var escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Multiplicacao();
                    break;
                case 4:
                    Divisao();
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;
            }


            Console.ReadKey();

        }


    }

}
