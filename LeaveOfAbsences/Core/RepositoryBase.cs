using LeaveOfAbsences.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LeaveOfAbsences.Core
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        private DbContext _context;
        private DbSet<T> _dbSet;


        public RepositoryBase(DbContext context)
        {
            this._context = context;
            this._dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            this._dbSet.Add(entity);
        }

        public IEnumerable<T> All()
        {
            return this._dbSet.ToList();
        }

        public T Find(Expression<Func<T, bool>> predicate = null)
        {
            return this._dbSet.Find(predicate);
        }

        public T GetById(int id)
        {
            return this._dbSet.Find(id);
        }

        public void Remove(int id)
        {
            var c = this._dbSet.Find(id);
            this._dbSet.Remove(c);
        }

        public void Update(T entity)
        {
            this._dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
