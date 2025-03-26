using Microsoft.AspNetCore.Mvc;
using School.Domain.Entities;
using School.Domain.Repository;

namespace SchoolApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Department>>> GetDepartments()
        {
            var departments = await _departmentRepository.GetAllAsync();
            return Ok(departments);
        }

        [HttpPost]
        public async Task<ActionResult<Department>> CreateDepartment(Department department)
        {
            await _departmentRepository.AddAsync(department);
            return CreatedAtAction(nameof(GetDepartments), new { id = department.Id }, department);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDepartment(int id, Department department)
        {
            if (id != department.Id)
            {
                return BadRequest();
            }

            await _departmentRepository.UpdateAsync(department);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            await _departmentRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
