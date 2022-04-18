using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCollectionsAssignment
{
    public class GenericRepository<T> : IGenericRepository<T> where T : IEntity
    {

        private readonly ICollection<T> _entities;

        public GenericRepository(ICollection<T> entities)
        {
            _entities = entities;
        }

        public void Add(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int id = _entities.Count();
            item.Id = id;
            _entities.Add(item);
        }

        public void Delete(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            _entities.Remove(item);
        }

        public T Get(int id)
        {
            return _entities.Where(x => x.Id == id).FirstOrDefault();
        }

        public ICollection<T> GetAll()
        {
            return _entities.ToList();
        }

        public void Update(T item)
        {
            IEntity oldEntity = _entities.Where(oldEntity => oldEntity.Id == item.Id).First();

            if (oldEntity != null)
            {
                oldEntity = item;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
    }
}
