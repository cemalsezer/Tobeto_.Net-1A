using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Course : Entity<Guid>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int InstructorId { get; set; }
        public Instructor? CourseInstructor { get; set; }
        public int CategoryId { get; set; }
        public Category? CourseCategory { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public double Price { get; set; }


    }
}
