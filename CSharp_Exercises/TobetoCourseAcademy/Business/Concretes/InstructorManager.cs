using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    internal class InstructorManager : IInstructorService
    {
        IInstructorDal _instructorDal;
        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }
        public IResult Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
            return new SuccessResult(Messages.InstructorAdd);
        }

        public IResult Delete(Instructor instructor)
        {
            _instructorDal.Delete(instructor);
            return new SuccessResult(Messages.InstructorDeleted);
        }
        public IResult Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
            return new SuccessResult(Messages.InstructorUpdated);
        }
        public IDataResult<List<Instructor>> GetAll()
        {
            return new SuccesDataResult<List<Instructor>>(_instructorDal.GetAll());
        }

        public IDataResult<List<Instructor>> GetByInstructorId(int id)
        {
            return new SuccesDataResult<List<Instructor>>(_instructorDal.GetAll(i=>i.InstructorId==id));
        }

        public IDataResult<List<Instructor>> GetByCategoryId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
