using System;
using System.Collections;
using System.Collections.Generic;
using Zip;

namespace Exercise1
{
    internal class Program
    {
        static IEnumerable<int> Range(int init, int stop, int jump)
        {
            // Crea un IEnumerable con todos los numeros
            // desde init hasta stop, de jump en jump.
            int i = init;
            while (i <= stop)
            {
                yield return i;
                i += jump;
            }
        }

        static void Main(string[] args)
        {
            #region Test1
            Console.WriteLine("Test #1");
            IEnumerable<int> pares = Range(0, 10, 2);
            IEnumerable<int> impares = Range(1, 10, 2);

            Console.Write("Usando la clase Zip: ");
            foreach (int i in new Zip<int>(pares, impares))
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.Write("\nUsando el metodo zip: ");
            foreach (int i in ZipMethod.zip(pares, impares))
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine("\n");
            #endregion
            // Salida 
            // Usando la clase Zip: 0 1 2 3 4 5 6 7 8 9 10
            // Usando el metodo zip: 0 1 2 3 4 5 6 7 8 9 10

            #region Test2
            Console.WriteLine("Test #2");
            IEnumerable<int> pares_hasta_20 = Range(0, 20, 2);
            IEnumerable<int> impares_hasta_5 = Range(1, 5, 2);

            Console.Write("Usando la clase Zip: ");
            foreach (int i in new Zip<int>(pares_hasta_20, impares_hasta_5))
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.Write("\nUsando el metodo zip: ");
            foreach (int i in ZipMethod.zip(pares_hasta_20, impares_hasta_5))
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine("\n");
            #endregion
            // Salida 
            // Usando la clase Zip: 0 1 2 3 4 5 6 8 10 12 14 16 18 20
            // Usando el metodo zip: 0 1 2 3 4 5 6 8 10 12 14 16 18 20

            #region Test3
            Console.WriteLine("Test #3");
            IEnumerable<int> pares_hasta_5 = Range(0, 5, 2);
            IEnumerable<int> impares_hasta_20 = Range(1, 20, 2);

            Console.Write("Usando la clase Zip: ");
            foreach (int i in new Zip<int>(pares_hasta_5, impares_hasta_20))
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.Write("\nUsando el metodo zip: ");
            foreach (int i in ZipMethod.zip(pares_hasta_5, impares_hasta_20))
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine("\n");
            #endregion
            // Salida 
            // Usando la clase Zip: 0 1 2 3 4 5 7 9 11 13 15 17 19
            // Usando el metodo zip: 0 1 2 3 4 5 7 9 11 13 15 17 19
        }
    }
}