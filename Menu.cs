using System;

namespace editorHTML
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOpitions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }
        public static void DrawScreen()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");
            Console.Write("+");
            Console.Write("\n");

            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");
                Console.Write("\n");
            }
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");
            Console.Write("+");
            Console.Write("\n");
        }
        public static void WriteOpitions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("==============");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("selecione uma opçao abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - abrir ");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("opçao: ");



        }
        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("view"); break;
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