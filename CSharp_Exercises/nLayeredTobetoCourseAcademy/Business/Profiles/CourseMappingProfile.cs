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
    public class CourseMappingProfile : Profile
    {
        public CourseMappingProfile()
        {
            CreateMap<Course, CreateCourseRequest>().ReverseMap();
            CreateMap<Course, CreatedCourseResponse>().ReverseMap();
            CreateMap<Course, UpdateCourseRequest>().ReverseMap();
            CreateMap<Course, UpdatedCourseResponse>().ReverseMap();
            CreateMap<Course, DeleteCourseRequest>().ReverseMap();
            CreateMap<Course, DeletedCourseResponse>().ReverseMap();
            CreateMap<Course, GetCourseResponse>()
                .ForMember(destinationMember: c => c.CategoryName, memberOptions: opt => opt.MapFrom(c => c.Category.Name))
                .ForMember(destinationMember: c => c.InstructorName, memberOptions: opt => opt.MapFrom(c => c.Instructor.Name))
                .ReverseMap();
            CreateMap<Course, GetListCourseResponse>()
                .ForMember(destinationMember: c => c.CategoryName, memberOptions: opt => opt.MapFrom(c => c.Category.Name))
                .ForMember(destinationMember: c => c.InstructorName, memberOptions: opt => opt.MapFrom(c => c.Instructor.Name))
                .ReverseMap();
            CreateMap<Paginate<Course>, Paginate<GetListCourseResponse>>().ReverseMap();
        }
    }
}
