using System;
using System.Globalization;
using System.Threading;

namespace CronometroSimples
{
    static class CronometroSimples
    {
        static void Main(string[] args)
        {
            MenuCronometro();
        }
        static void CronometroCrescente()
        {
            System.Console.WriteLine("Por favor informe o tempo que você quer cronometrar: ");
            var tempoCronometro = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int count;
            for (count = 0; tempoCronometro > count; count++)
            {
                Console.Clear();
                System.Console.WriteLine(count);
                Thread.Sleep(1000);

            }
            if (count >= 60)
            {
                Console.WriteLine("Deseja converter seu tempo de 'segundos' para 'minutos'?");
                var resposta = Console.ReadLine().ToLower();
                double conversao;

                if (resposta == "sim")
                {
                    Console.WriteLine("Convertendo...");
                    Thread.Sleep(1000);
                    conversao = (double)count / 60;
                    Console.WriteLine($"Seu tempo foi convertido para {conversao.ToString("F2", CultureInfo.InvariantCulture)} minutos");
                }
                else
                {
                    FinalizarCronometro();
                }
            }
        }
        static void FinalizarCronometro()
        {
            Console.Clear();
            Console.WriteLine("Cronometro finalizado... Retornando ao menu em breve");
            Thread.Sleep(1000);
            MenuCronometro();
        }
        static void CronometroRegressivo()
        {
            Console.WriteLine("Por favor informe o tempo que você quer cronometrar: ");
            var tempoCronometroDecre = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (tempoCronometroDecre >= 60)
            {
                Console.WriteLine("Deseja converter seu tempo de 'segundos' para 'minutos'?");
                var resposta = Console.ReadLine().ToLower();
                double conversao = 0.0;




                if (resposta == "sim")
                {
                    conversao = tempoCronometroDecre / 60.0;
                    for (double count = conversao; count >= 0; count -= 0.01)
                    {
                        Console.Clear();
                        Console.WriteLine((count).ToString("F2", CultureInfo.InvariantCulture));
                        Thread.Sleep(1000);
                    }
                }
            else
            {
                for (int count = tempoCronometroDecre; count >= 0; count--)
                {

                    Console.Clear();
                    Console.WriteLine(count);
                    Thread.Sleep(500);
                }
            }
            }

            Console.Clear();
            System.Console.WriteLine("Cronometro finalizado... Retornando ao menu em breve");
            Thread.Sleep(500);
            MenuCronometro();
        }
        static void MenuCronometro()
        {
            Console.WriteLine("Por favor escolha uma opção do menu: ");
            Console.WriteLine("--------------------------------------- ");
            Console.WriteLine("1 - Cronômetro Crescente (Segundos) ");
            Console.WriteLine("2 - Cronômetro Decrescente (Segundos) ");
            Console.WriteLine("0 - Sair ");

            var opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CronometroCrescente();
                    break;
                case 2:
                    CronometroRegressivo();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    MenuCronometro();
                    break;
            }

            Console.ReadKey();
        }
    }
}

