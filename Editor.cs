using System;
using System.Text;

namespace editorHTML
{

    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("modo editor");
            Console.WriteLine("------------");
            Start();

        }
        public static void Start()
        {
            var file = new StringBuilder();
            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine("------------");
            Console.WriteLine("deseja salvar o arquivo?");
            Viewer.Show(file.ToString());
        }
    }
}