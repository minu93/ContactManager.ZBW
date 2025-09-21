using ContactManager.Application.Abstractions;
using ContactManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContactManager.Infrastructure.Persistence
{
    public sealed class UserRepository : IUserRepository
    {
        private readonly ContactManagerDbContext _db;
        public UserRepository(ContactManagerDbContext db) => _db = db;

        public Task<User?> GetByUserNameAsync(string userName)
            => _db.Users.AsNoTracking().FirstOrDefaultAsync(u => u.UserName == userName);

        public Task<bool> AnyAsync()
            => _db.Users.AnyAsync();

        public async Task AddAsync(User user)
        {
            _db.Users.Add(user);
            await _db.SaveChangesAsync();
        }
    }
}
