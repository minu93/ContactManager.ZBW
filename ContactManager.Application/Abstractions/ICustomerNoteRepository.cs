using ContactManager.Domain.Entities;

namespace ContactManager.Application.Abstractions;

public interface ICustomerNoteRepository
{
    Task<IReadOnlyList<CustomerNote>> GetAllAsync();
    Task<IReadOnlyList<CustomerNote>> GetForCustomerAsync(Guid customerId);


    Task AddAsync(CustomerNote entity);

    Task UpdateAsync(CustomerNote entity);

    Task DeleteAsync(CustomerNote entity);
}