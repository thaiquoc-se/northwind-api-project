using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class GenericRepository<T, Tkey> : IGenericRepository<T, Tkey> where T : class
    {
        private readonly IGenericDAO<T,Tkey> _genericDAO;
        public GenericRepository(IGenericDAO<T, Tkey> genericDAO) 
        {
            _genericDAO = genericDAO;
        }
        public Task Add(T entity) => _genericDAO.Add(entity);
        

        public IQueryable<T> Find(Expression<Func<T, bool>> expression) => _genericDAO.Find(expression);


        public IQueryable<T> Find(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includes) => _genericDAO.Find(where, includes);

        public IQueryable<T> GetAll() => _genericDAO.GetAll();


        public Task<T> GetByID(Tkey id) => _genericDAO.GetByID(id);
        

        public Task<bool> Remove(Tkey id) => _genericDAO.Remove(id);
        

        public void Update(T entity) => _genericDAO.Update(entity);
        
    }
}
