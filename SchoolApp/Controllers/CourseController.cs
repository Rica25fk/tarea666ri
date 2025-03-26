using Microsoft.AspNetCore.Mvc;
using School.Domain.Entities;
using School.Domain.Repository;

namespace SchoolApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository;

        public CourseController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Course>>> GetCourses()
        {
            var courses = await _courseRepository.GetAllAsync();
            return Ok(courses);
        }

        [HttpPost]
        public async Task<ActionResult<Course>> CreateCourse(Course course)
        {
            await _courseRepository.AddAsync(course);
            return CreatedAtAction(nameof(GetCourses), new { id = course.Id }, course);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCourse(int id, Course course)
        {
            if (id != course.Id)
            {
                return BadRequest();
            }

            await _courseRepository.UpdateAsync(course);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            await _courseRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
