using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 10; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10 - i; j++)
                {
                    Console.Write(' ');
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 10; i >= 0; i--)
            {
                for (int j = 0; j <= 10 - i; j++)
                {
                    Console.Write(' ');
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
        }
    }
}
