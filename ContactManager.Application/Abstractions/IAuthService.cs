using ContactManager.Domain.Entities;

namespace ContactManager.Application.Abstractions
{
    public interface IAuthService
    {
        Task<User?> LoginAsync(string userName, string password);
        Task<User> CreateUserAsync(string userName, string password,
                                      string? displayName = null);
    }
}
