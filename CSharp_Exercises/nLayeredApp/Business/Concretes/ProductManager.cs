using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        private IMapper _mapper;
        private ProductBusinessRules _productBusinessRules;

        public ProductManager(IProductDal productDal, IMapper mapper, ProductBusinessRules productBusinessRules)
        {
            _productDal = productDal;
            _mapper = mapper;
            _productBusinessRules = productBusinessRules;
        }

        public async Task<CreatedProductResponse> Add(CreateProductRequest createProductRequest)
        {
            await _productBusinessRules.EachCategoryCanContainMax20Products(createProductRequest.CategoryId);
            Product product = _mapper.Map<Product>(createProductRequest);

            Product createdProduct = await _productDal.AddAsync(product);

            CreatedProductResponse createdProductResponse = _mapper.Map<CreatedProductResponse>(createdProduct);

            return createdProductResponse;
        }

        public async Task<Paginate<GetListedProductResponse>> GetListAsync()
        {
            var data = await _productDal.GetListAsync(include: p => p.Include(p => p.category));

            var result = _mapper.Map<Paginate<GetListedProductResponse>>(data);
            return result;
        }

    }
}