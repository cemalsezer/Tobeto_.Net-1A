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
    public class InstructorMapping : Profile
    {
        public InstructorMapping()
        {
            CreateMap<CreatedInstructorResponse, Instructor>().ReverseMap();
            CreateMap<CreateInstructorRequest, Instructor>().ReverseMap();
            CreateMap<Paginate<Instructor>, Paginate<CreatedInstructorResponse>>().ReverseMap();
        }
    }
}
