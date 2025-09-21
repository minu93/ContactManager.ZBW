using ContactManager.Application.Abstractions;
using ContactManager.Domain.Entities;
using ContactManager.Domain.Errors;

namespace ContactManager.Application.Services
{
    public sealed class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repo;

        public CustomerService(ICustomerRepository repo)
        {
            _repo = repo;
        }

        public async Task CreateAsync(Customer c)
        {
            if (await _repo.ExistsDuplicateAsync(c))
                throw new DomainValidationException(
                    "Kunde existiert bereits");
            await _repo.AddAsync(c);
        }

        public async Task UpdateAsync(Customer c)
        {
            await _repo.UpdateAsync(c);
        }

        public Task DeleteAsync(Customer c) => _repo.DeleteAsync(c);
    }
}