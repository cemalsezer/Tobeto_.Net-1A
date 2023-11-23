using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public IResult Add(Course course)
        {
            if (course.Name.Length < 2)
            {
                return new ErrorResult(Messages.CourseNameInvalid);
            }
            _courseDal.Add(course);
            return new SuccessResult(Messages.CoursesAdded);
        }

        public IResult Delete(Course course)
        {
            _courseDal.Delete(course);
            return new SuccessResult(Messages.CoursesDeleted);
        }

        public IResult Update(Course course)
        {
            _courseDal.Update(course);
            return new SuccessResult(Messages.CoursesUpdated);
        }

        public IDataResult<List<Course>> GetAll()
        {
            if(DateTime.Now.Hour == 12)
            {
                return new ErrorDataResult<List<Course>>(Messages.MaintenanceTime);
            }
            return new SuccesDataResult<List<Course>>(_courseDal.GetAll(),Messages.CourseListed);
        }

        public IDataResult<List<Course>> GetByCourseId(int id)
        {
            return new SuccesDataResult<List<Course>>(_courseDal.GetAll(c => c.Id == id));
        }

       
    }
}
