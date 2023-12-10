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

namespace Business.Mapping
{
    public class CourseMapping : Profile
    {
        public CourseMapping()
        {
            CreateMap<CreatedCourseResponse, Course>().ReverseMap();
            CreateMap<CreateCourseRequest, Course>().ReverseMap();
            CreateMap<Paginate<Course>, Paginate<CreatedCourseResponse>>().ReverseMap();
        }
    }
}
