using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IInstructorService
    {
        public IDataResult<List<Instructor>> GetAll();
        public IDataResult<List<Instructor>> GetByInstructorId(int id);
        public IResult Add(Instructor instructor);
        public IResult Update(Instructor instructor);
        public IResult Delete(Instructor instructor);
    }
}
