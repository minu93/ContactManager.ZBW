using ContactManager.Domain.Entities;


namespace ContactManager.Application.Abstractions
{
    public interface ICustomerService
    {
        Task CreateAsync(Customer customer);
        Task UpdateAsync(Customer customer);

        Task DeleteAsync(Customer customer);

    }
}