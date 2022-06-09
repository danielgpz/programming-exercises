using System.Collections;
using System.Collections.Generic;

namespace Zip
{
    public class Zip<T>: IEnumerable<T> 
    {
        class _Zip : IEnumerator<T>
        {
            bool first;
            IEnumerator<T> Enum1;
            IEnumerator<T> Enum2;
            public _Zip(IEnumerator<T> enum1, IEnumerator<T> enum2)
            {
                Enum1 = enum1;
                Enum2 = enum2;
                first = true;
            }

            public bool MoveNext()
            {
                if (first && Enum1.MoveNext()) 
                {
                    first = false;
                    return true;
                }

                if (Enum2.MoveNext()) 
                {
                    first = true;
                    return true;
                }

                if (Enum1.MoveNext())
                {
                    first = false;
                    return true;
                }

                return false;
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
                    if (first)
                    {
                        return Enum2.Current;
                    }

                    return Enum1.Current;
                }
            }

            public void Reset()
            {
                Enum1.Reset();
                Enum2.Reset();
                first = true;
            }

            public void Dispose()
            {
                Enum1.Dispose();
                Enum2.Dispose();
            }
        }


        IEnumerable<T> Enum1;
        IEnumerable<T> Enum2;
        
        public Zip(IEnumerable<T> enum1, IEnumerable<T> enum2) 
        {
            Enum1 = enum1;
            Enum2 = enum2;
        }

        public IEnumerator<T> GetEnumerator() 
        {
            return new _Zip(Enum1.GetEnumerator(), Enum2.GetEnumerator());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}