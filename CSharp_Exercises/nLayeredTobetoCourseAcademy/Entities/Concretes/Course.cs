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
        public string Name { get; set; }
        public Guid InstructorId { get; set; }
        public Guid CategoryId { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public double Price { get; set; }
        public Instructor? CourseInstructor { get; set; } //FK
        public Category? CourseCategory { get; set; } //FK




    }
}
