using BusinessObjects.Models;
using DataAccessObjects;
using DataAccessObjects.DAOs;
using Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class ProductRepository : GenericRepository<Product, int>, IProductRepository
    {
        public ProductRepository(IGenericDAO<Product, int> genericDAO) : base(genericDAO)
        {
        }
    }
}
