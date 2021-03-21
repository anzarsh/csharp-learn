using System;
using System.Threading;

namespace SetCursorPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random random = new Random();
                int randX = random.Next(100);
                int randY = random.Next(100);
                Console.SetCursorPosition(randX, randY);
                Console.Write("*");
                Console.SetCursorPosition(100, 100);
                Thread.Sleep(25);
            }
        }
    }
}
