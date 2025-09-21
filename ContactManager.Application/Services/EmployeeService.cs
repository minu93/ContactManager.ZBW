using ContactManager.Application.Abstractions;
using ContactManager.Domain.Entities;

namespace ContactManager.Application.Services
{
    public sealed class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repo;

        public EmployeeService(IEmployeeRepository repo)
        {
            _repo = repo;
        }

        public Task CreateAsync(Employee employee)
        {
            return _repo.AddAsync(employee);
        }

        public Task UpdateAsync(Employee employee)
        {
            return _repo.UpdateAsync(employee);
        }

        public Task DeleteAsync(Employee employee)
        {
            return _repo.DeleteAsync(employee);
        }
    }
}
