using System;
using System.Threading;

namespace Wait
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0, d = 1; i < 20; i++, d *= 2)
            {
                Console.WriteLine(d);
                Thread.Sleep(500);
            }

            Console.ReadKey();
        }
    }
}
