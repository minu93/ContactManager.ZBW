using ContactManager.Domain.Entities;

namespace ContactManager.Application.Abstractions
{
    public interface IEmployeeRepository
    {

        Task<IReadOnlyList<Employee>> GetAllAsync();
        Task<IReadOnlyList<Employee>> GetEmployeesOnlyAsync();
        Task<IReadOnlyList<Trainee>> GetTraineesAsync();

        Task AddAsync(Employee entity);
        Task UpdateAsync(Employee entity);
        Task DeleteAsync(Employee entity);
    }
}
