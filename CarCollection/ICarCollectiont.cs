using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public interface ICarCOllection<T>
    {
        void Add(T a);

        T this[string name] { get; }

        int Count { get; }

        void Clear();
    }
}
