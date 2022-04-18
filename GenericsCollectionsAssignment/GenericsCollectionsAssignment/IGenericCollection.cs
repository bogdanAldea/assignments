using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCollectionsAssignment
{
    public interface IGenericCollection<T>
    {

        public void Set(T item, int index);
        public T Get(int index);
        public void Swap(int indexA, int indexB);

        public int GetLength();
    }
}
