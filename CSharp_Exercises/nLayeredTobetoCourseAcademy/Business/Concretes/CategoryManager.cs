using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        IMapper _mapper;

        public CategoryManager(ICategoryDal categoryDal, IMapper mapper)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;
        }


        public async Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest)
        {
            Category category = _mapper.Map<Category>(createCategoryRequest);
            var createdCategory = await _categoryDal.AddAsync(category);
            CreatedCategoryResponse createdCategoryResponse = _mapper.Map<CreatedCategoryResponse>(createdCategory);
            return createdCategoryResponse;
        }

        public async Task<DeletedCategoryResponse> Delete(DeleteCategoryRequest deleteCategoryRequest)
        {
            Category category = await _categoryDal.GetAsync(c => c.Id == deleteCategoryRequest.Id);
            var deletedCategory = await _categoryDal.DeleteAsync(category);
            DeletedCategoryResponse deletedCategoryResponse = _mapper.Map<DeletedCategoryResponse>(deletedCategory);
            return deletedCategoryResponse;
        }

        public async Task<GetCategoryResponse> GetAsync(Expression<Func<Category, bool>> filter)
        {
            var result = await _categoryDal.GetAsync(filter);
            GetCategoryResponse getCategoryResponse = _mapper.Map<GetCategoryResponse>(result);
            return getCategoryResponse;
        }

        public async Task<Paginate<GetListCategoryResponse>> GetListAsync()
        {
            var result = await _categoryDal.GetListAsync();
            Paginate<GetListCategoryResponse> getListedCategoryResponse = _mapper.Map<Paginate<GetListCategoryResponse>>(result);
            return getListedCategoryResponse;
        }

        public async Task<UpdatedCategoryResponse> Update(UpdateCategoryRequest updateCategoryRequest)
        {
            Category category = _mapper.Map<Category>(updateCategoryRequest);
            var updatedCategory = await _categoryDal.UpdateAsync(category);
            UpdatedCategoryResponse updatedCategoryResponse = _mapper.Map<UpdatedCategoryResponse>(updatedCategory);
            return updatedCategoryResponse;
        }
    }
}
