using AutoMapper;
using BusinessObjects.Models;

namespace API.DTOs
{
    public class ProductDTO 
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string? SupplierName { get; set; }
        public string? CategoryName{ get; set; }
        public string? QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
    }
}
