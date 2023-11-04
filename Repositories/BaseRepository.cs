using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BaseRepository<T, Tkey> : IBaseRepository<T, Tkey> where T : class
    {
        private readonly IBaseDAO<T,Tkey> _baseDAO;
        public BaseRepository(IBaseDAO<T, Tkey> genericDAO) 
        {
            _baseDAO = genericDAO;
        }
        public virtual Task Add(T entity) => _baseDAO.Add(entity);
        
        public virtual IQueryable<T> Find(Expression<Func<T, bool>> expression) => _baseDAO.Find(expression);

        public virtual IQueryable<T> Find(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includes) => _baseDAO.Find(where, includes);

        public virtual IQueryable<T> GetAll() => _baseDAO.GetAll();

        public virtual Task<T> GetByID(Tkey id) => _baseDAO.GetByID(id);
        
        public virtual Task<bool> Remove(Tkey id) => _baseDAO.Remove(id);
        
        public virtual void Update(T entity) => _baseDAO.Update(entity);
        
    }
}
