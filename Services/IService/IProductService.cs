using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IService
{
    public interface IProductService
    {
        IQueryable<Product> GetAllProducts();
        Task<Product> GetProductByID(int id);
        Task Add(Product product);
        void Update(Product product);
        Task<bool> Remove(int id);
    }
}
