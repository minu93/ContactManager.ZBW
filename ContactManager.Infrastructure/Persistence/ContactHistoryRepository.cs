using ContactManager.Application.Abstractions;
using ContactManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContactManager.Infrastructure.Persistence
{
    public sealed class ContactHistoryRepository : IContactHistoryRepository
    {
        private readonly ContactManagerDbContext _db;
        public ContactHistoryRepository(ContactManagerDbContext db) => _db = db;

        public async Task AddAsync(ContactChange change)
        {
            _db.ContactChanges.Add(change);
            await _db.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<ContactChange>> GetByPersonAsync(Guid personId)
            => await _db.ContactChanges
                       .Where(x => x.PersonId == personId)
                       .OrderByDescending(x => x.OccurredAt)
                       .ToListAsync();
    }
}
