using ContactManager.Application.Abstractions;
using ContactManager.Domain.Entities;

namespace ContactManager.Application.Services
{
    public sealed class CustomerNoteService : ICustomerNoteService
    {
        private readonly ICustomerNoteRepository _repo;
        public CustomerNoteService(ICustomerNoteRepository repo)
        {
            _repo = repo;
        }
        public Task CreateAsync(CustomerNote note) => _repo.AddAsync(note);
        public Task UpdateAsync(CustomerNote note) => _repo.UpdateAsync(note);
        public Task DeleteAsync(CustomerNote note) => _repo.DeleteAsync(note);

    }
}
