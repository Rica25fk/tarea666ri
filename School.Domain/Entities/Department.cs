﻿using School.Domain.Core;

namespace School.Domain.Entities
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
