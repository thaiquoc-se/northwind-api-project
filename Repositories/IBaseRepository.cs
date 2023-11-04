using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IBaseRepository<T, TKey> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> Find(Expression<Func<T, bool>> expression);
        IQueryable<T> Find(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includes);
        Task Add(T entity);
        Task<bool> Remove(TKey id);
        void Update(T entity);
        Task<T> GetByID(TKey id);
    }
}
