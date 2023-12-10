using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class InstructorManager : IInstructorService
    {
        private IInstructorDal _instructorDal;
        private readonly IMapper _mapper;
        public InstructorManager(IInstructorDal instructorDal, IMapper mapper)
        {
            _instructorDal = instructorDal;
            _mapper = mapper;
        }      

        public async Task<Paginate<CreatedInstructorResponse>> GetListAsync()
        {
            var result = await _instructorDal.GetListAsync();
            return _mapper.Map<Paginate<CreatedInstructorResponse>>(result);
        }

        public async Task<CreatedInstructorResponse> Add(CreateInstructorRequest createInstructorRequest)
        {
            Instructor instructor = _mapper.Map<Instructor>(createInstructorRequest);
            var createInstructor = await _instructorDal.AddAsync(instructor);
            return _mapper.Map<CreatedInstructorResponse>(createInstructor);

        }
    }
}
