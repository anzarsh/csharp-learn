using System;

namespace Ref2
{
    class Program
    {
        static void RemoveByIndex<T>(ref T[] arr, int index)
        {
            T[] newArr = new T[arr.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArr[i] = arr[i];
            }

            for (int i = index + 1; i < arr.Length; i++)
            {
                newArr[i - 1] = arr[i];
            }

            arr = newArr;
        }

        static void RemoveLast<T>(ref T[] arr)
        {
            RemoveByIndex(ref arr, arr.Length - 1);
        }

        static void RemoveFirst<T>(ref T[] arr)
        {
            RemoveByIndex(ref arr, 0);
        }

        static void Main(string[] args)
        {
            int[] arr = { 3, 5, 6, 7, 0, 3 };

            RemoveByIndex(ref arr, 3);
            RemoveFirst(ref arr);
            RemoveLast(ref arr);
        }
    }
}
