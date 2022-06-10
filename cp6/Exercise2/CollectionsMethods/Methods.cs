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
            int i = 0;
            foreach (T elem in enumerable) 
            {
                if (i++ >= count)
                    break;
                yield return elem;
            }
        }

        // Tomar solo los elementos que pasan el filtro filter
        public static IEnumerable<T> Filter<T>(IEnumerable<T> enumerable, Func<T, bool> filter)
        {
            foreach (T elem in enumerable) 
            {
                if (filter.Invoke(elem))
                    yield return elem;
            }
        }

        // Transformar los elementos del enumerable usando la funcion map
        public static IEnumerable<T2> Map<T1, T2>(IEnumerable<T1> enumerable, Func<T1, T2> map)
        {
            foreach (T1 elem in enumerable)
                yield return map(elem);
        }

        // Tomar un solo elemento por cada subsecuencia maximal de elementos
        // iguales
        public static IEnumerable<T> Distinct<T>(IEnumerable<T> enumerable, Func<T, T, bool> comparer)
        {
            IEnumerator<T> aux = enumerable.GetEnumerator();
            if (aux.MoveNext()) 
            {
                T last = aux.Current;
                yield return last;
                foreach (T elem in enumerable)
                {
                    if (!comparer(elem, last))
                        yield return elem;
                    last = elem;
                }
            }
        }

        // Concatenar los enumerables contenidos en un enumerable coleccion en
        // un unico enumerable
        public static IEnumerable<T> Concat<T>(IEnumerable<IEnumerable<T>> collection)
        {
            foreach (IEnumerable<T> enumerable in collection)
            {
                foreach (T elem in enumerable)
                {
                    yield return elem;
                }
            }
        }

        // Repetir cada elemento del enumerable la cantidad de veces que indique
        // la funcion repeat para dicho elemento
        public static IEnumerable<T> Repeat<T>(IEnumerable<T> enumerable, Func<T, int> repeat)
        {
            foreach (T elem in enumerable)
            {
                int times = repeat(elem);
                while (times-- > 0)
                    yield return elem;
            }
        }
    }
}