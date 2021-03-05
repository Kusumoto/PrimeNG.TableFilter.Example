using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PrimeNG.TableFilter.Example.Infrastructure
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private const string EntityNullError = "Entity is null value";
     
        private readonly EntityContext _context;
        private readonly DbSet<T> _entities;

        public Repository(EntityContext context)
        {
            this._context = context;
            _entities = context.Set<T>();
        }

        public void Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(EntityNullError);

            _entities.Remove(entity);
        }

        public T Find(params object[] keyValues) => _entities.Find(keyValues);

        public IEnumerable<T> GetAll() => _entities.AsEnumerable();

        public IQueryable<T> Gets() => _entities;

        public void SaveChanges() => _context.SaveChanges();

        public void Insert(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(EntityNullError);

            _entities.Add(entity);
        }

        public void Remove(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(EntityNullError);

            _entities.Remove(entity);
        }

        public void Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(EntityNullError);

            _context.Update(entity);
        }
    }

}