using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects.DAOs
{
    public class ProductDAO : GenericDAO<ProductDAO, int>, IGenericDAO<ProductDAO, int>
    {
        public ProductDAO(NorthwindContext context) : base(context)
        {
        }
    }
}
