using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class BaseDAO<T, Tkey> : IBaseDAO<T, Tkey> where T : class
    {
        private readonly NorthwindContext _context;
        private readonly DbSet<T> dbSet;
        public BaseDAO(NorthwindContext context) 
        {
            _context = context;
            dbSet = _context.Set<T>();
        }

        public virtual async Task Add(T entity)
        {
            await dbSet.AddAsync(entity);
        }

        public virtual IQueryable<T> Find(Expression<Func<T, bool>> expression)
        {
            return dbSet.Where(expression);
        }

        public virtual IQueryable<T> Find(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includes)
        {
            var result = dbSet.Where(where);

            foreach (var include in includes)
            {
                result = result.Include(include);
            }
            return result;
        }

        public virtual IQueryable<T> GetAll()
        {
            return dbSet;
        }

        public virtual async Task<T> GetByID(Tkey id)
        {
            return await dbSet.FindAsync(id) ?? throw new Exception();
        }

        public virtual async Task<bool> Remove(Tkey id)
        {
            T? entity = await dbSet.FindAsync(id);
            if (entity == null)
            {
                return false;   
            }
            dbSet.Remove(entity);
            return true;
        }

        public void Update(T entity)
        {
            _context.Entry<T>(entity).State = EntityState.Modified;
        }
    }
}
