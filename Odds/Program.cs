using System;

namespace Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                int start, end;

                try
                {
                    Console.WriteLine("Введите начало диапазона:");
                    start = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите конец диапазона:");
                    end = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка! Введите корретные числа");
                    Console.ReadKey();
                    continue;
                }
                

                int odds = 0;
                int evens = 0;
                int currentNumber = start;
                while (currentNumber <= end)
                {
                    if (currentNumber % 2 == 0)
                    {
                        evens++;
                    }
                    else
                    {
                        odds++;
                    }
                    currentNumber++;
                }

                Console.WriteLine("Количество четных чисел: " + evens);
                Console.WriteLine("Количество не четных чисел: " + odds);

                Console.ReadKey();
            }
        }
    }
}
