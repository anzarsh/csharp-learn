using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parse, TryParse

            string str = "1.4";

            try
            {
                NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
                {
                    NumberDecimalSeparator = ".",
                };
                double a = double.Parse(str, numberFormatInfo);
                Console.WriteLine("Число = " + a);
            } catch(Exception)
            {
                Console.WriteLine("Не удалось распарсить строку");
            }

            string str2 = "1.3dd ddd";

            int b;

            bool result = int.TryParse(str2, out b);

            if (result)
            {
                Console.WriteLine("Второе число = " + b);
            }
            else
            {
                Console.WriteLine("Не удалось распарсить второе число");
            }
        }
    }
}
