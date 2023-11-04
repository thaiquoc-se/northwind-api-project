using BusinessObjects.Models;
using DataAccessObjects.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepository
{
    public interface IProductRepository : IBaseRepository<Product,int>
    {
    }
}
