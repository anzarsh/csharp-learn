using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // string name = Console.ReadLine();

            // Console.WriteLine("Привет " + name + "!!!");

            // convert
            string str;
            int a, b, result;

            Console.WriteLine("Введите первое число:");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);

            Console.WriteLine("Введите второе число:");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);

            result = a + b;

            Console.WriteLine("Сумма чисел " + a + " и " + b + " равна " + result);
        }
    }
}
