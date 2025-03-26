using School.Domain.Entities;
using School.Domain.Repository;
using School.Infrastructure.Context;
using School.Infrastructure.Core;

namespace School.Infrastructure.Repositories
{
    public class CourseRepository : BaseRepository<Course>, ICourseRepository
    {
        public CourseRepository(SchoolContext context) : base(context) { }
    }
}
