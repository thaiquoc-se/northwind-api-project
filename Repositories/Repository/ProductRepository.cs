using BusinessObjects.Models;
using DataAccessObjects;
using DataAccessObjects.DAOs;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class ProductRepository : BaseRepository<Product, int>, IProductRepository
    {
        public ProductRepository(IBaseDAO<Product, int> baseDAO) : base(baseDAO)
        {
        }
        public override IQueryable<Product> GetAll()
        {
            return base.GetAll().Include(p => p.Category).Include(p => p.Supplier);
        }

    }
}
