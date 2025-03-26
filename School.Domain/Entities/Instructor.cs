using School.Domain.Core;

namespace School.Domain.Entities
{
    public class Instructor : Person
    {
        public ICollection<Course> Courses { get; set; }
    }
}
