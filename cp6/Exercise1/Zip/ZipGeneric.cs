using System.Collections;
using System.Collections.Generic;

namespace Zip
{
    public class Zip<T>: IEnumerable<T> 
    {
        IEnumerable<T> Enum1;
        IEnumerable<T> Enum2;
        
        public Zip(IEnumerable<T> enum1, IEnumerable<T> enum2) 
        {
            Enum1 = enum1;
            Enum2 = enum2;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator() 
        {
            // Se retorna una instancia de la clase que
            // tienen que implementar (_Zip)
            return new _Zip(Enum1.GetEnumerator(), Enum2.GetEnumerator());
        }

        // Clase donde tienen que implementar los métodos
        class _Zip : IEnumerator<T>
        {
            // Recomendación: bool first;
            IEnumerator<T> Enum1;
            IEnumerator<T> Enum2;
            public _Zip(IEnumerator<T> enum1, IEnumerator<T> enum2)
            {
                Enum1 = enum1;
                Enum2 = enum2;
                // Recomendación: first = true;
            }

            public bool MoveNext()
            {
                // Borra la linea debajo y escribe tu código
                throw new NotImplementedException();
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public T Current
            {
                get
                {
                    // Borra la linea debajo y escribe tu código
                    throw new NotImplementedException();
                }
            }

            public void Reset()
            {
                Enum1.Reset();
                Enum2.Reset();
                // Recomendación: first = true;
            }

            public void Dispose()
            {
                Enum1.Dispose();
                Enum2.Dispose();
            }
        }
    }
}