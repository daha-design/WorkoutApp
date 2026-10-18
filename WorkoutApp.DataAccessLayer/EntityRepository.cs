using System.Collections.Generic;
using System.Linq;
using WorkoutApp.Domain;

namespace WorkoutApp.DataAccessLayer
{
    public class EntityRepository<T> : IRepository<T> where T : class, IDomainObject
    {
        private readonly WorkoutAppDbContext _context;

        public EntityRepository()
        {
            _context = new WorkoutAppDbContext();
        }

        public void Add(T item) { _context.Set<T>().Add(item); _context.SaveChanges(); }

        public void Update(T item)
        {
            var existing = _context.Set<T>().Find(item.Id);
            if (existing == null) return;
            _context.Entry(existing).CurrentValues.SetValues(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var item = _context.Set<T>().Find(id);
            if (item == null) return;
            _context.Set<T>().Remove(item);
            _context.SaveChanges();
        }

        public IEnumerable<T> ReadAll() => _context.Set<T>().ToList();
        public T ReadById(int id) => _context.Set<T>().Find(id);
    }
}
