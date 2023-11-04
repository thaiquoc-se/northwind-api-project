using API.DTOs;
using AutoMapper;
using BusinessObjects.Models;

namespace API.Mapper
{
    public class ProductMapper : Profile
    {
        public ProductMapper()
        {
            CreateMap<Product, ProductDTO>().ForMember(dest => dest.CategoryName, opt => opt
                                            .MapFrom(src => src.Category!.CategoryName))
                                            .ForMember(dest => dest.SupplierName, opt => opt
                                            .MapFrom(src => src.Supplier!.CompanyName))
                                            .ReverseMap();
        }
    }
}
