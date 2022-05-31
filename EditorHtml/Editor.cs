using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorHtml.obj
{
    public class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("----------------------------------------");
            Start();
        }

        public static void Start()
        {

            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Deseja salvar este arquivo?");

            
             Viewer.Show(file.ToString());
        }
    }
}