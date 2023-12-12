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
            CreateMap<CreatedProductResponse, Product>().ReverseMap();
            CreateMap<CreateProductRequest, Product>().ReverseMap();
            CreateMap<Paginate<Product>, Paginate<GetListedProductResponse>>().ReverseMap();
            CreateMap<Product, GetListedProductResponse>()
                .ForMember(destinationMember: p => p.CategoryName, memberOptions: opt => opt.MapFrom(p => p.category.CategoryName))
                .ForMember(destinationMember: i => i.InstructorName, memberOptions: opt => opt.MapFrom(i => i.category.CategoryName))
                .ReverseMap();
        }

    }
}
