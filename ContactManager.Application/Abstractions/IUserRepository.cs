using ContactManager.Domain.Entities;

namespace ContactManager.Application.Abstractions
{
    public interface IUserRepository
    {
        Task<User?> GetByUserNameAsync(string userName);
        Task<bool> AnyAsync();
        Task AddAsync(User user);
    }
}
