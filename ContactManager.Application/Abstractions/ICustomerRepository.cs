using ContactManager.Domain.Entities;

namespace ContactManager.Application.Abstractions;

public interface ICustomerRepository
{
    Task<IReadOnlyList<Customer>> GetAllAsync();
    Task AddAsync(Customer entity);
    Task UpdateAsync(Customer entity);
    Task DeleteAsync(Customer entity);

    Task<bool> ExistsDuplicateAsync(Customer entity);
}
