using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCourseDal : EfEntityRepositoryBase<Course, TobetoCourseAcademyContext>, ICourseDal
    {
        public List<CourseDetailDto> GetCourseDetails()
        {
            using(TobetoCourseAcademyContext context = new TobetoCourseAcademyContext())
            {
                var result = from c in context.Courses
                             join ca in context.Categories
                             on c.CategoryId equals ca.Id
                             join i in context.Instructors
                             on c.InstructorId equals i.InstructorId
                             select new CourseDetailDto
                             {
                                 Id = c.Id,
                                 Name = c.Name,
                                 CategoryId = ca.Id,
                                 CategoryName = ca.Name,
                                 InstructorId = i.InstructorId,
                                 InstructorName = i.Name
                             };
                return result.ToList();
            }
        }
            
    }
}
