using ContactManager.Domain.Entities;

namespace ContactManager.Application.Abstractions
{
    public interface IEmployeeService
    {
        Task CreateAsync(Employee employee);
        Task UpdateAsync(Employee employee);
        Task DeleteAsync(Employee employee);
    }
}
