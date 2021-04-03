using System;

namespace Ref
{
    class Program
    {
        static ref int Foo(int[] arr)
        {
            return ref arr[0];
        }

        static void Main(string[] args)
        {
            int a = 3;

            ref int b = ref a;

            b = 2;

            // 2
            Console.WriteLine(a);

            /////////////////////////////

            int[] f = new int[] { 3, 5, 7 };

            ref int d = ref Foo(f);

            d = 10;

            //10
            Console.WriteLine(f[0]);
        }
    }
}
