using System;

namespace Cursor
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 10;
            while(true)
            {
                Draw(x, y);
                ConsoleKey key = Console.ReadKey().Key;

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        x--;
                        break;
                    case ConsoleKey.UpArrow:
                        y--;
                        break;
                    case ConsoleKey.RightArrow:
                        x++;
                        break;
                    case ConsoleKey.DownArrow:
                        y++;
                        break;
                }
            }
        }

        static void Draw(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("*");
            Console.SetCursorPosition(0, 0);
        }
    }
}
