using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RaksApi.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public Entities _context { get; set; }
        public DbSet<T> _dbSet { get; set; }

        public BaseRepository(Entities context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public virtual IEnumerable<T> GetAll()
        {
            IQueryable<T> query = _dbSet;
            return query;
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }
    }
}