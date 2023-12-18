using AutoMapper;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class ProductMappingProfiles : Profile
    {
        public ProductMappingProfiles()
        {
            CreateMap<Product, GetListedProductResponse>()
            .ForMember(destinationMember: p => p.CategoryName,
                       memberOptions: opt => opt.MapFrom(p => p.category.Name))
            .ReverseMap();

            CreateMap<IPaginate<Product>, Paginate<GetListedProductResponse>>();
            CreateMap<Product, CreateProductRequest>().ReverseMap();
            CreateMap<Product, CreatedProductResponse>().ReverseMap();
        }

    }
}
