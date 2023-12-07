﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Category : Entity<Guid>
    {
        List<Course> Courses = new List<Course>();
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
