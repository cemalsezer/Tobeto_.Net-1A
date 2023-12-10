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
    public class CourseManager : ICourseService
    {
        private ICourseDal _courseDal;
        private readonly IMapper _mapper;

        public CourseManager(ICourseDal courseDal, IMapper mapper)
        {
            _courseDal = courseDal;
            _mapper = mapper;
        }
        public async Task<CreatedCourseResponse> Add(CreateCourseRequest createCourseRequest)
        {
            Course course = _mapper.Map<Course>(createCourseRequest);
            var createCourse = await _courseDal.AddAsync(course);
            return _mapper.Map<CreatedCourseResponse>(createCourse);
        }

        public async Task<Paginate<CreatedCourseResponse>> GetListAsync()
        {
            var result = await _courseDal.GetListAsync();
            return _mapper.Map<Paginate<CreatedCourseResponse>>(result);
        }
    }
}
