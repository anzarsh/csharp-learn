using System;
using System.Linq;

namespace RepeatValueArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // {5, 5, 5, 5, 5, 5, 5, 5, 5, 5}
            int[] arr1 = Enumerable.Repeat(5, 10).ToArray();

            // {5, 6, 7, 8, 9, 10, 11, 12, 13, 14}
            int[] arr2 = Enumerable.Range(5, 10).ToArray();

            // {0, 0, 0, 0, 0}
            int[] arr3 = new int[5];

            // { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
            int[] arr4 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            // { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
            int[] arr5 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            // { 1, 2, 3, 4, 5 }
            int[] arr6 = new[] { 1, 2, 3, 4, 5 };
        }
    }
}
