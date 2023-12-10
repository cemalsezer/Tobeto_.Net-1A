using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
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
        private readonly IMapper _mapper;

        public ProductManager(IProductDal productDal, IMapper mapper)
        {
            _productDal = productDal;
            _mapper = mapper;
        }
        public async Task<CreatedProductResponse> Add(CreateProductRequest createProductRequest)
        {
            Product product = _mapper.Map<Product>(createProductRequest);
            var createProduct = await _productDal.AddAsync(product);
            return _mapper.Map<CreatedProductResponse>(createProduct);
            //Product product = new Product();
            //product.Id=Guid.NewGuid();
            //product.ProductName= createProductRequest.ProductName;
            //product.QuantityPerUnit=createProductRequest.QuantityPerUnit;
            //product.UnitPrice=createProductRequest.UnitPrice;
            //product.UnitsInStock = createProductRequest.UnitsInStock;

            //Product createdProduct = await _productDal.AddAsync(product);

            //CreatedProductResponse createdProductResponse = new CreatedProductResponse();
            //createdProductResponse.Id = createdProduct.Id;
            //createdProductResponse.ProductName= createProductRequest.ProductName;
            //createdProductResponse.QuantityPerUnit = createProductRequest.QuantityPerUnit;
            //createdProduct.UnitPrice= createProductRequest.UnitPrice;
            //createdProduct.UnitsInStock= createProductRequest.UnitsInStock;

            //return createdProductResponse;
        }
        public async Task<Paginate<CreatedProductResponse>> GetListAsync()
        {
            var result = await _productDal.GetListAsync();
            return _mapper.Map<Paginate<CreatedProductResponse>>(result);
        }

        
    }
}
