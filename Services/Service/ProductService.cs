using BusinessObjects.Models;
using Repositories.IRepository;
using Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task Add(Product product) => await _productRepository.Add(product);

        public IQueryable<Product> GetAllProducts() => _productRepository.GetAll();
        

        public async Task<Product> GetProductByID(int id) => await _productRepository.GetByID(id);
        

        public async Task<bool> Remove(int id) => await _productRepository.Remove(id);
        

        public void Update(Product product) => _productRepository.Update(product);
        
    }
}
