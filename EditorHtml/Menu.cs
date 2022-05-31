using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
            WriteOptions();

            var culturaPT = new CultureInfo("pt-BR");

            var options = byte.Parse(Console.ReadLine());
        }

        public static void DrawScreen()
        {

            DrawHorizontalLines();

            Console.Write("\n");

            DrawVerticalLines();

            DrawHorizontalLines();
        }

        public static void DrawHorizontalLines()
        {
            Console.Write("+");
            for (int i = 0; i <= 38; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
        }
        public static void DrawVerticalLines()
        {
            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 38; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
        }
        public static void WriteOptions()

        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===========");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo: ");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOptions(byte option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Viewer.Show(""); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0); break;
                    }
                default: Show(); break;
            }
        }
    }
}