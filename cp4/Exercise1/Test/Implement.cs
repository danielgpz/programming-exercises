using System.Collections.Generic;
using System;

/*
namespace System.Collections.Generic
{
    //
    // Summary:
    //     Defines a method that a type implements to compare two objects.
    //
    // Type parameters:
    //   T:
    //     The type of objects to compare.
    public interface IComparer<in T>
    {
        //
        // Summary:
        //     Compares two objects and returns a value indicating whether one is less than,
        //     equal to, or greater than the other.
        //
        // Parameters:
        //   x:
        //     The first object to compare.
        //
        //   y:
        //     The second object to compare.
        //
        // Returns:
        //     A signed integer that indicates the relative values of x and y, as shown in the
        //     following table.
        //     Value – Meaning
        //     Less than zero – x is less than y.
        //     Zero – x equals y.
        //     Greater than zero – x is greater than y.
        int Compare(T? x, T? y);
    }
}
*/

namespace Test
{
    // Example of a concrete implemantation of a generic Interface
    public class IntComparer : IComparer<int>
    {
        public int Compare(int x, int y) 
        {
            return x - y;
        } 
    }

    // Example of a concrete implemantation of a generic Interface for severals types
    public class MultiComparer : IComparer<int>, IComparer<string> {
        public int Compare(int x, int y)
        {
            return y - x;
        }

        public int Compare(string? a, string? b)
        {
            string x = a == null ? "" : a;
            string y = b == null ? "" : b;
            int n = Math.Min(x.Length, y.Length);
            for (int i = 0; i < n; i++) {
                if (x[i] > y[i]) {
                    return -1;
                }
            }

            return x.Length - y.Length;
        }
    } 
}