using School.Domain.Entities;

namespace School.Domain.Repository
{
    public interface IDepartmentRepository
    {
        Task<Department> GetByIdAsync(int id);
        Task<IEnumerable<Department>> GetAllAsync();
        Task AddAsync(Department department);
        Task UpdateAsync(Department department);
        Task DeleteAsync(int id);
    }
}
