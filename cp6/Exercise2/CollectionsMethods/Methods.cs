using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsMethods
{
    public static class Methods
    {
        // Imprime un enumerable en la consola
        public static void Print<T>(IEnumerable<T> enumerable) 
        {
            foreach (T elem in enumerable) 
            {
                Console.Write(elem);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        // Tomar los primeros count elementos de un enumerable
        public static IEnumerable<T> Take<T>(IEnumerable<T> enumerable, int count) 
        {
            // Borre debajo y escriba su código
            throw new NotImplementedException();
        }

        // Tomar solo los elementos que pasan el filtro filter
        public static IEnumerable<T> Filter<T>(IEnumerable<T> enumerable, Func<T, bool> filter)
        {
            // Borre debajo y escriba su código
            throw new NotImplementedException();
        }

        // Transformar los elementos del enumerable usando la función map
        public static IEnumerable<T2> Map<T1, T2>(IEnumerable<T1> enumerable, Func<T1, T2> map)
        {
            // Borre debajo y escriba su código
            throw new NotImplementedException();
        }

        // Tomar un solo elemento por cada subsecuencia maximal de elementos
        // iguales
        public static IEnumerable<T> Distinct<T>(IEnumerable<T> enumerable, Func<T, T, bool> comparer)
        {
            // Borre debajo y escriba su código
            throw new NotImplementedException();
        }

        // Concatenar los enumerables contenidos en un enumerable colección en
        // un único enumerable
        public static IEnumerable<T> Concat<T>(IEnumerable<IEnumerable<T>> collection)
        {
            // Borre debajo y escriba su código
            throw new NotImplementedException();
        }

        // Repetir cada elemento del enumerable la cantidad de veces que indique
        // la función repeat para dicho elemento
        public static IEnumerable<T> Repeat<T>(IEnumerable<T> enumerable, Func<T, int> repeat)
        {
            // Borre debajo y escriba su código
            throw new NotImplementedException();
        }
    }
}