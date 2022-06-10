using System;
using System.Collections;
using System.Collections.Generic;
using CollectionsMethods;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Test1
            Console.WriteLine("Test #1");
            int[] arr1 = new int[] { 1, 2, 3, 0, 4, -9, 11, 129, -78, 34 };
            IEnumerable<int> take = Methods.Take(arr1, 6);
            Methods.Print(take);
            Console.WriteLine();
            #endregion
            // Salida: 1 2 3 0 4 -9

            #region Test2
            Console.WriteLine("Test #2");
            int[] arr2 = new int[] { 11, 20, -3, 101, 46, 88899, 113, 19, -42 };
            IEnumerable<int> filter = Methods.Filter(arr2, x => x%2 == 0);
            Methods.Print(filter);
            Console.WriteLine();
            #endregion
            // Salida: 20 46 -42

            #region Test3
            Console.WriteLine("Test #3");
            int[] arr3 = new int[] { 21, 72, 3, -161, -603, 11189, 13, -9234, 512 };
            IEnumerable<double> map = Methods.Map(arr3, x => (x/2.0));
            Methods.Print(map);
            Console.WriteLine();
            #endregion
            // Salida: 10.5 36 1.5 -80.5 -301.5 5594.5 6.5 -4617 256

            #region Test4
            Console.WriteLine("Test #4");
            int[] arr4 = new int[] { 1, 1, 1, 1, 2, 2, 3, 4, 4, 4, 4, 4, 5, 5, 5 };
            IEnumerable<int> distinct = Methods.Distinct(arr4, (x, y) => x == y);
            Methods.Print(distinct);
            Console.WriteLine();
            #endregion
            // Salida: 1 2 3 4 5

            #region Test5
            Console.WriteLine("Test #5");
            IEnumerable<int>[] arr5 = new IEnumerable<int>[] { take, filter, distinct };
            IEnumerable<int> concat = Methods.Concat(arr5);
            Methods.Print(concat);
            Console.WriteLine();
            #endregion
            // Salida: 1 2 3 0 4 -9 20 46 -42 1 2 3 4 5

            #region Test6
            Console.WriteLine("Test #6");
            string[] arr6 = new string[] { "a", "bc", "def" };
            IEnumerable<string> repeat = Methods.Repeat(arr6, s => s.Length);
            Methods.Print(repeat);
            Console.WriteLine();
            #endregion
            // Salida: a bc bc def def def
        }
    }
}