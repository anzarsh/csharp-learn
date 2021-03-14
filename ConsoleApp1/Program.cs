using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // string name = Console.ReadLine();

            // Console.WriteLine("Привет " + name + "!!!");

            // convert
            //string str;
            //int a, b, result;

            //console.writeline("введите первое число:");
            //str = console.readline();
            //a = convert.toint32(str);

            //console.writeline("введите второе число:");
            //console.writeline("введите второе число:");
            //str = console.readline();
            //b = convert.toint32(str);

            //result = a + b;

            //console.writeline("сумма чисел " + a + " и " + b + " равна " + result);

            // globalization

            string str = "1.3";

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            double a = Convert.ToDouble(str, numberFormatInfo);

            Console.WriteLine(a);
        }
    }
}
