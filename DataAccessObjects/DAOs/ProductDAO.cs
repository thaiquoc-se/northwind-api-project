using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects.DAOs
{
    public class ProductDAO : BaseDAO<Product, int>, IBaseDAO<Product, int>
    {
        public ProductDAO(NorthwindContext context) : base(context)
        {
        }
    }
}
