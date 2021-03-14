using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
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
