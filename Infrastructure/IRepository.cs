using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeNG.TableFilter.Example.Infrastructure
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();

        IQueryable<T> Gets();

        T Find(params Object[] keyValues);

        void Insert(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Remove(T entity);

        void SaveChanges();
    }

}