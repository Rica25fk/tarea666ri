using School.Domain.Core;

namespace School.Domain.Entities
{
    public class Course : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
