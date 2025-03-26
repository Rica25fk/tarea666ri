using School.Domain.Core;

namespace School.Domain.Entities
{
    public class Student : Person
    {
        public ICollection<Course> Courses { get; set; }
    }
}
