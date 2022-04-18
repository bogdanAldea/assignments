using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCollectionsAssignment
{
    internal class GenericCollection<T> : IGenericCollection<T>
    {

        private T[] _array;

        public GenericCollection(T[] array)
        {
            _array = array;
        }

        public T Get(int index)
        {
            if (index < 0 || index > _array.Length)
            {
                throw new ArgumentOutOfRangeException("Index is either out of range or has negative value.");
            }
            return _array[index];
        }

        public int GetLength()
        {
            return _array.Length;
        }

        public void Set(T item, int index)
        {
            _array[index] = item;
        }

        public void Swap(int indexA, int indexB)
        {
            T itemToSwap;

            itemToSwap = _array[indexA];
            _array[indexA] = _array[indexB];
            _array[indexB] = itemToSwap;
        }
    }
}
