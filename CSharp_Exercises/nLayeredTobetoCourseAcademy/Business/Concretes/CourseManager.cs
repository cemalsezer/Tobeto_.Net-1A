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
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        IMapper _mapper;

        public CourseManager(ICourseDal courseDal, IMapper mapper)
        {
            _courseDal = courseDal;
            _mapper = mapper;
        }

        public async Task<CreatedCourseResponse> Add(CreateCourseRequest createCourseRequest)
        {
            Course course = _mapper.Map<Course>(createCourseRequest);
            var result = await _courseDal.AddAsync(course);
            CreatedCourseResponse createdCourseResponse = _mapper.Map<CreatedCourseResponse>(result);
            return createdCourseResponse;
        }

        public async Task<DeletedCourseResponse> Delete(DeleteCourseRequest deleteCourseRequest)
        {
            Course course = await _courseDal.GetAsync(c => c.Id == deleteCourseRequest.Id);
            var deletedCourse = await _courseDal.DeleteAsync(course);
            DeletedCourseResponse deletedCourseResponse = _mapper.Map<DeletedCourseResponse>(deletedCourse);
            return deletedCourseResponse;
        }

        public async Task<GetCourseResponse> GetAsync(Expression<Func<Course, bool>> filter)
        {
            var result = await _courseDal.GetAsync(filter, include: c => c.Include(c => c.Category).Include(c => c.Instructor));
            GetCourseResponse getCourseResponse = _mapper.Map<GetCourseResponse>(result);
            return getCourseResponse;
        }

        public async Task<Paginate<GetListCourseResponse>> GetListAsync()
        {
            var result = await _courseDal.GetListAsync(include: c => c.Include(c => c.Category).Include(c => c.Instructor));
            Paginate<GetListCourseResponse> getListedCourseResponse = _mapper.Map<Paginate<GetListCourseResponse>>(result);
            return getListedCourseResponse;
        }

        public async Task<UpdatedCourseResponse> Update(UpdateCourseRequest updateCourseRequest)
        {
            Course course = _mapper.Map<Course>(updateCourseRequest);
            var updatedCourse = await _courseDal.UpdateAsync(course);
            UpdatedCourseResponse updatedCourseResponse = _mapper.Map<UpdatedCourseResponse>(updatedCourse);
            return updatedCourseResponse;
        }
    }
}
