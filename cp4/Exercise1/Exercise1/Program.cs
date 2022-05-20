using Test;
using System;
using System.Collections.Generic;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates instances of the 2 comparers
            IntComparer int_comparer = new IntComparer();
            MultiComparer multi_comparer = new MultiComparer();

            // A list of int
            List<int> int_list = new List<int> { 6, 4, 9, 32, 86, 3, 12 };
            Console.WriteLine(string.Join(" ", int_list.Select(x => x.ToString())));

            // Sorting using int_comparer
            int_list.Sort(int_comparer);
            Console.WriteLine(string.Join(" ", int_list.Select(x => x.ToString())));

            // Sorting using multi_comparer
            int_list.Sort(multi_comparer);
            Console.WriteLine(string.Join(" ", int_list.Select(x => x.ToString())));

            // A list of string
            List<string> str_list = new List<string> { "may", "the", "force", "be", "with", "you" };
            
            // Uncomment this down to see the error
            // str_list.Sort(int_comparer);
            Console.WriteLine(string.Join(" ", str_list));
            
            // Sorting using multi_comparer
            str_list.Sort(multi_comparer);
            Console.WriteLine(string.Join(" ", str_list));


            // Contravariance
            IEqual<Employee> iee = new PersonEqual();
            // IEqual<Person> iep = new EmployeeEqual();

            // Covariance
            IGenerator<Person> igp = new EmployeeGenerator();
            // IGenerator<Employee> ige = new PersonGenerator();

            // No variance
            // ICopy<Person> icp = new EmployeeCopy();
            // ICopy<Employee> ice = new PersonCopy();
        }
    }
}

