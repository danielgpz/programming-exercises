using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public interface IEqual<in T>
    {
        public bool Equals(T a, T b);
    }

    public interface IGenerator<out T>
    {
        public T Generate(int x);
    }

    public interface ICopy<T>
    {
        public T Copy(T a);
    }
}
