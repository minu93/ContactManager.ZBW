using ContactManager.Application.Abstractions;
using ContactManager.Domain.Entities;

namespace ContactManager.Infrastructure.Persistence
{
    public sealed class AuthService : IAuthService
    {
        private readonly IUserRepository _users;

        public AuthService(IUserRepository users) => _users = users;

        public async Task<User?> LoginAsync(string userName, string password)
        {
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrEmpty(password))
                return null;

            var user = await _users.GetByUserNameAsync(userName.Trim());
            if (user is null || !user.IsActive) return null;


            return BCrypt.Net.BCrypt.Verify(password, user.PasswordHash) ? user : null;
        }

        public async Task<User> CreateUserAsync(string userName, string password, string? displayName = null)
        {
            userName = userName.Trim();
            if (string.IsNullOrWhiteSpace(userName)) throw new ArgumentException("Benutzername ist leer.");
            if (string.IsNullOrEmpty(password)) throw new ArgumentException("Passwort ist leer.");

            var exists = await _users.GetByUserNameAsync(userName);
            if (exists != null) throw new InvalidOperationException("Benutzername existiert bereits.");

            var user = new User
            {
                UserName = userName,
                DisplayName = displayName ?? userName,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(password)
            };

            await _users.AddAsync(user);
            return user;
        }

    }
}
