using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Instructor:IEntity

    {
        List<Course> Courses = new List<Course>();

        public int InstructorId { get; set; }
        public string Name { get; set; }

    }
}
