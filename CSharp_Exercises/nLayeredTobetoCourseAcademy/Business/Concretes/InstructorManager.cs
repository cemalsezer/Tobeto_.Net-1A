using Business.Abstracts;
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
        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }
        public async Task Add(Instructor instructor)
        {
            await _instructorDal.AddAsync(instructor);
        }

        public async Task Delete(Instructor instructor)
        {
            await _instructorDal.DeleteAsync(instructor);

        }

        public async Task<Paginate<Instructor>> GetListAsync()
        {
            var result = await _instructorDal.GetListAsync();
            return result;
        }

        public async Task Update(Instructor instructor)
        {
            await _instructorDal.UpdateAsync(instructor);

        }
    }
}
