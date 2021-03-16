using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;

            double b = 1.0;

            // True
            Console.WriteLine(a == b);

            int c = 3;

            string d = "3";

            // True
            Console.WriteLine(c == Convert.ToInt32(d));
        }
    }
}
