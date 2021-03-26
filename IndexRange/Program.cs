using System;

namespace IndexRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 8, 2, 8, 0, 3, 2, 5, 8 };

            int[] arr2 = arr[3..6];

            arr2[0] = -1;

            // 2
            Console.WriteLine(arr[3]);
        }
    }
}
