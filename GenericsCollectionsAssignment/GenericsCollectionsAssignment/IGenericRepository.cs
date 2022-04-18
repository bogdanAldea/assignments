using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCollectionsAssignment
{
    public interface IGenericRepository<T>
    {
        
        public T Get(int id);
        public ICollection<T> GetAll();
        public void Add(T item);
        public void Update(T item);
        public void Delete(T item);


    }
}
