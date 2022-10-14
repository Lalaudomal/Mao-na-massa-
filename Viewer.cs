using System;
using System.Text.RegularExpressions;

namespace editorHTML
{

    public class Viewer
    {
        public static void Show(string Text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("modo Visualização");
            Console.WriteLine("------------");
            Replace(Text);
            Console.WriteLine("------------");
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string Text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = Text.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(words[i].Substring(words[i].IndexOf('>') + 1, ((words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>'))));
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write("");
                }
            }

        }
    }
}