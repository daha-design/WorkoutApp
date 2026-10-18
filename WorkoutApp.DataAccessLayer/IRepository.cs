using System.Collections.Generic;
using WorkoutApp.Domain;

namespace WorkoutApp.DataAccessLayer
{
    public interface IRepository<T> where T : IDomainObject
    {
        void Add(T item);
        void Update(T item);
        void Delete(int id);
        IEnumerable<T> ReadAll();
        T ReadById(int id);
    }
}